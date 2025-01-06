using ManagingTheatreApp.Interaction;
using ManagingTheatreApp.Interaction.Out;
using System.Text.Json;
using System.Text;

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

    /// <summary>
    /// Получение мест.
    /// </summary>
    public Task<List<LocationInfo>> GetLocations(int actId)
    {
        return SendResponse(rcl => rcl.GetJson<List<LocationInfo>>($"https://localhost:6001/gateway/location/act/{actId}"));
    }

    /// <summary>
    /// Изменение цены.
    /// </summary>
    public Task ChangePrice(ChangePrice info)
    {
        var content = new StringContent(
         JsonSerializer.Serialize(info),
         Encoding.UTF8,
         "application/json"
        );

        return _restClient.Put($"https://localhost:6001/gateway/location/price", content, _token);
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
