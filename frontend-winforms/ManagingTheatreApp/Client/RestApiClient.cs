using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;

namespace ManagingTheatreApp.Client;

/// <summary>
/// Реализация RestAPI-клиента.
/// </summary>
public class RestApiClient
{
    public RestApiClient()
    {
        _httpClient = new HttpClient();
    }

    public RestApiClient(string url)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(url)
        };
    }

    public async Task<string?> Get(string url)
    {
        var ResponseMsg = await _httpClient.GetAsync(url);

        CheckResponseMsg(ResponseMsg);

        return await ResponseMsg.Content.ReadAsStringAsync();
    }

    public async Task<T?> GetJson<T>(string url, Func<HttpResponseMessage, bool> processFunc)
    {
        var ResponseMsg = await _httpClient.GetAsync(url);

        if (processFunc(ResponseMsg))
        {
            return default;
        }

        CheckResponseMsg(ResponseMsg);

        return await ResponseMsg.Content.ReadFromJsonAsync<T>();
    }

    public async Task<T?> GetJson<T>(string url)
    {
        var ResponseMsg = await _httpClient.GetAsync(url);

        CheckResponseMsg(ResponseMsg);

        Console.WriteLine(await ResponseMsg.Content.ReadAsStringAsync());

        var options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        return await ResponseMsg.Content.ReadFromJsonAsync<T>(options);
    }

    public async Task<HttpResponseMessage> Post(string url, HttpContent content)
    {
        var Result = await _httpClient.PostAsync(url, content);

        await CheckResponseMsg(Result);

        return Result;
    }

    public async Task<string> StringPost(string url, HttpContent content)
    {
        var Result = await Post(url, content);

        return await Result.Content.ReadAsStringAsync();
    }

    public async Task Put(string url)
    {
        var ResponseMsg = await _httpClient.PutAsync(url, null);

        await CheckResponseMsg(ResponseMsg);
    }

    private async Task CheckResponseMsg(HttpResponseMessage? message)
    {
        if (message == null)
        {
            throw new InvalidOperationException("Отсутствует содержимое сообщения");
        }

        if (!message.IsSuccessStatusCode)
        {
            var problemDetails = await message.Content.ReadFromJsonAsync<ProblemDetails>();

            throw new Exception($"Http-ответ содержит код ошибки: {problemDetails!.Status}. {problemDetails.Detail}");
        }
    }

    private readonly HttpClient _httpClient;
}
