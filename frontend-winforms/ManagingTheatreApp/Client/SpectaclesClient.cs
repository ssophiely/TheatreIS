using ManagingTheatreApp.Interaction;
using ManagingTheatreApp.Interaction.Out;
using System.Text.Json;
using System.Text;

namespace ManagingTheatreApp.Client;

/// <summary>
/// Клиент сервиса спектаклей.
/// </summary>
internal class SpectaclesClient
{
    public SpectaclesClient()
    {
        _restClient = new RestApiClient(_url);
    }

    /// <summary>
    /// Получение спектаклей.
    /// </summary>
    public Task<List<SpectacleInfo>> GetSpectacles()
    {
        return SendResponse(rcl => rcl.GetJson<List<SpectacleInfo>>($"https://localhost:6001/gateway/spectacles"));
    }

    /// <summary>
    /// Получение спектакля.
    /// </summary>
    public Task<SpectacleInfo> GetSpectacle(int id)
    {
        return SendResponse(rcl => rcl.GetJson<SpectacleInfo>($"https://localhost:6001/gateway/spectacles/{id}"));
    }

    /// <summary>
    /// Получение жанров.
    /// </summary>
    public Task<List<GenreInfo>> GetGenres()
    {
        return SendResponse(rcl => rcl.GetJson<List<GenreInfo>>($"https://localhost:6001/gateway/spectacles/genres"));
    }

    /// <summary>
    /// Удаление спектакля.
    /// </summary>
    public Task DeleteSpectacle(int id)
    {
        return _restClient.Delete($"https://localhost:6001/gateway/spectacles/{id}");
    }

    /// <summary>
    /// Получение сотрудников.
    /// </summary>
    public Task<List<EmployeeInfo>> GetEmployees()
    {
        return SendResponse(rcl => rcl.GetJson<List<EmployeeInfo>>($"https://localhost:6001/gateway/employees"));
    }

    /// <summary>
    /// Создание спектакля.
    /// </summary>
    public Task CreateSpectacle(CreateSpectacle info)
    {
        var content = new StringContent(
           JsonSerializer.Serialize(info),
           Encoding.UTF8,
           "application/json"
       );

        return _restClient.Post($"https://localhost:6001/gateway/spectacles", content);
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

    private const string _url = @"http://localhost:1002";
}
