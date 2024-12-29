using System.Text.Json;
using System.Text;

namespace ManagingTheatreApp.Client;

/// <summary>
/// Клиент сервиса авторизации.
/// </summary>
internal class AuthenticationClient
{
    public AuthenticationClient()
    {
        _restClient = new RestApiClient(_url);
    }

    /// <summary>
    /// Авторизация администратора.
    /// </summary>
    /// <returns>JWT-токен</returns>
    public Task<string> VerifyAdmin(string login, string pas)
    {
        var content = new StringContent(
           JsonSerializer.Serialize(new { name = login, password = pas }),
           Encoding.UTF8,
           "application/json"
       );

        return SendStringPostResponse(rcl => rcl.StringPost($"https://localhost:6001/gateway/auth/admin/verify", content));
    }

    /// <summary>
    /// Добавление УЗ администратора.
    /// </summary>
    public Task AddAdmin(string login, string pas)
    {
        var content = new StringContent(
           JsonSerializer.Serialize(new { name = login, password = pas }),
           Encoding.UTF8,
           "application/json"
       );

        return _restClient.Post($"https://localhost:6001/gateway/auth/admin", content);
    }


    private async Task<T> SendGetResponse<T>(Func<RestApiClient, Task<T?>> func)
    {
        var result = await func(_restClient);

        if (result == null)
        {
            throw new Exception($"Не удалось разобрать результат типа {typeof(T)}");
        }

        return result;
    }

    private async Task<string> SendStringPostResponse(Func<RestApiClient, Task<string>> func)
    {
        var result = await func(_restClient);

        if (result == null)
        {
            throw new Exception($"Не удалось разобрать результат типа string");
        }

        return result;
    }


    private readonly RestApiClient _restClient;

    private const string _url = @"http://localhost:1001";
}
