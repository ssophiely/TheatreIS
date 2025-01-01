using SharedUtils;
using Tickets.Interaction;

namespace Tickets.Clients;

/// <summary>
/// Клиент сервиса репертуара.
/// </summary>
public class RepertoireClient
{
    public RepertoireClient()
    {
        _restClient = new RestApiClient(_url);
    }

    /// <summary>
    /// Получение спектакля.
    /// </summary>
    public Task<ActInfo> GetActInfo(int? id)
    {
        return SendGetResponse(rcl => rcl.GetJson<ActInfo>($"http://Repertoire:8080/act/{id}"));
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


    private readonly RestApiClient _restClient;

    private const string _url = @"http://Tickets:1002";
}
