using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;

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

        await CheckResponseMsg(ResponseMsg);

        return await ResponseMsg.Content.ReadAsStringAsync();
    }

    public async Task<T?> GetJson<T>(string url, string? token = null)
    {
        if (token != null)
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var ResponseMsg = await _httpClient.GetAsync(url);

        _httpClient.DefaultRequestHeaders.Authorization = null;

        await CheckResponseMsg(ResponseMsg);

        var options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        return await ResponseMsg.Content.ReadFromJsonAsync<T>(options);
    }

    public async Task<string> StringPost(string url, HttpContent content)
    {
        var Result = await Post(url, content);

        return await Result.Content.ReadAsStringAsync();
    }

    public async Task<HttpResponseMessage> Post(string url, HttpContent content, string? token = null)
    {
        if (token != null)
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var Result = await _httpClient.PostAsync(url, content);

        _httpClient.DefaultRequestHeaders.Authorization = null;

        await CheckResponseMsg(Result);

        return Result;
    }

    public async Task Delete(string url, string? token = null)
    {
        if (token != null)
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var Result = await _httpClient.DeleteAsync(url);

        _httpClient.DefaultRequestHeaders.Authorization = null;

        await CheckResponseMsg(Result);
    }

    public async Task Put(string url, HttpContent content, string? token = null)
    {
        if (token != null)
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var ResponseMsg = await _httpClient.PutAsync(url, content);

        _httpClient.DefaultRequestHeaders.Authorization = null;

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
