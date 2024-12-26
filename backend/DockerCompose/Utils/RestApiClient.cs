using Microsoft.AspNetCore.WebUtilities;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace SharedUtils;

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

    public async Task Post(string url, IEnumerable<KeyValuePair<string, string?>> parameters)
    {
        // Передаем аргументы через запрос
        var DstUrl = QueryHelpers.AddQueryString(url, parameters);

        var Result = await _httpClient.PostAsync(DstUrl, null);

        CheckResponseMsg(Result);
    }

    public async Task Post(string url)
    {
        var Result = await _httpClient.PostAsync(url, null);

        CheckResponseMsg(Result);
    }

    public async Task Put(string url)
    {
        var ResponseMsg = await _httpClient.PutAsync(url, null);

        CheckResponseMsg(ResponseMsg);
    }

    private void CheckResponseMsg(HttpResponseMessage? message)
    {
        if (message == null)
        {
            throw new InvalidOperationException("Отсутствует содержимое сообщения");
        }

        if (!message.IsSuccessStatusCode)
        {
            throw new Exception($"Http-ответ содержит код ошибки: {message.StatusCode}");
        }
    }

    private readonly HttpClient _httpClient;
}
