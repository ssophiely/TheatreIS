using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;

namespace ManagingTheatreApp.Client;

/// <summary>
/// ���������� RestAPI-�������.
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

    public async Task<T?> GetJson<T>(string url)
    {
        var ResponseMsg = await _httpClient.GetAsync(url);

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

    public async Task<HttpResponseMessage> Post(string url, HttpContent content)
    {
        var Result = await _httpClient.PostAsync(url, content);

        await CheckResponseMsg(Result);

        return Result;
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
            throw new InvalidOperationException("����������� ���������� ���������");
        }

        if (!message.IsSuccessStatusCode)
        {
            var problemDetails = await message.Content.ReadFromJsonAsync<ProblemDetails>();

            throw new Exception($"Http-����� �������� ��� ������: {problemDetails!.Status}. {problemDetails.Detail}");
        }
    }

    private readonly HttpClient _httpClient;
}
