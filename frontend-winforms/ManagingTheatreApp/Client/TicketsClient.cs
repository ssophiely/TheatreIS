namespace ManagingTheatreApp.Client;

/// <summary>
/// Клиент сервиса билетов.
/// </summary>
public class TicketsClient
{
    public TicketsClient(string token)
    {
        _restClient = new RestApiClient(_url);
        _token = token;
    }

    /// <summary>
    /// Есть ли купленные билеты на показ.
    /// </summary>
    public Task<bool> CheckTickets(int actId)
    {
        return SendResponse(rcl => rcl.GetJson<bool>($"https://localhost:6001/gateway/tickets/check-payed/{actId}"));
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

    private const string _url = @"http://localhost:1004";
}
