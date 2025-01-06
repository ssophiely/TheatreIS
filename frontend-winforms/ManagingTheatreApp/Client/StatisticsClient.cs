using ManagingTheatreApp.Interaction;

namespace ManagingTheatreApp.Client;

/// <summary>
/// Клиент сервиса статистики.
/// </summary>
public class StatisticsClient
{
    public StatisticsClient(string token)
    {
        _restClient = new RestApiClient(_url);
        _token = token;
    }


    /// <summary>
    /// Получение кассовых сборов.
    /// </summary>
    public Task<List<SpectaclesBoxofficeYear>> GetBoxOffice()
    {
        return SendResponse(rcl => 
        rcl.GetJson<List<SpectaclesBoxofficeYear>>($"https://localhost:6001/gateway/statistics/admin/boxoffice", _token));
    }

    /// <summary>
    /// Получение количества билетов.
    /// </summary>
    public Task<List<SoldTicketsMonth>> GetTickets()
    {
        return SendResponse(rcl => 
        rcl.GetJson<List<SoldTicketsMonth>>($"https://localhost:6001/gateway/statistics/admin/sold-tickets", _token));
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

    private const string _url = @"http://localhost:1005";
}
