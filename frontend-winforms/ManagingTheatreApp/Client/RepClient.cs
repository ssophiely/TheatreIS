using ManagingTheatreApp.Interaction;
using ManagingTheatreApp.Interaction.Out;
using System.Text.Json;
using System.Text;

namespace ManagingTheatreApp.Client;

/// <summary>
/// Клиент сервиса репертуара.
/// </summary>
public class RepClient
{
    public RepClient(string token)
    {
        _restClient = new RestApiClient(_url);
        _token = token;
    }

    /// <summary>
    /// Получение репертуара.
    /// </summary>
    public Task<List<RepInfo>> GetRepertoire()
    {
        return SendResponse(rcl => rcl.GetJson<List<RepInfo>>($"https://localhost:6001/gateway/repertoire"));
    }

    /// <summary>
    /// Удаление репертуара.
    /// </summary>
    public Task DeleteRepertoire(int id)
    {
        return _restClient.Delete($"https://localhost:6001/gateway/repertoire/{id}", _token);
    }

    /// <summary>
    /// Создание репертуара.
    /// </summary>
    public Task AddRepertoire(CreateRep info)
    {
        var content = new StringContent(
         JsonSerializer.Serialize(info),
         Encoding.UTF8,
         "application/json"
        );

        return _restClient.Post($"https://localhost:6001/gateway/repertoire", content, _token);
    }

    /// <summary>
    /// Получение показов.
    /// </summary>
    public Task<List<ActInfo>> GetActs(int id)
    {
        return SendResponse(rcl => rcl.GetJson<List<ActInfo>>($"https://localhost:6001/gateway/act/{id}"));
    }

    /// <summary>
    /// Удаление показа.
    /// </summary>
    public Task DeleteAct(int id)
    {
        return _restClient.Delete($"https://localhost:6001/gateway/act/{id}", _token);
    }

    /// <summary>
    /// Создание показа.
    /// </summary>
    public Task AddAct(CreateAct info)
    {
        var content = new StringContent(
         JsonSerializer.Serialize(info),
         Encoding.UTF8,
         "application/json"
        );

        return _restClient.Post($"https://localhost:6001/gateway/act", content, _token);
    }


    private async Task<T> SendResponse<T>(Func<RestApiClient, Task<T?>> func)
    {
        var result = await func(_restClient);

        if (result == null)
        {
            throw new Exception($"Не удалось разобрать результат типа {typeof(T)}");
        }

        return result;
    }


    private readonly RestApiClient _restClient;

    private readonly string _token;

    private const string _url = @"http://localhost:1003";
}
