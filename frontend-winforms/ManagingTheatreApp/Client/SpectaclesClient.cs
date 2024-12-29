using ManagingTheatreApp.Interaction;

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
