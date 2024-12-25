using SharedUtils;
using Repertoire.Interaction;

namespace Repertoire.Clients;

/// <summary>
/// Клиент сервиса спектаклей.
/// </summary>
public class SpectaclesClient
{
    public SpectaclesClient()
    {
        _restClient = new RestApiClient(_url);
    }

    /// <summary>
    /// Получение спектакля.
    /// </summary>
    public Task<SpectacleInfo> GetSpectacle(int id)
    {
        return SendGetResponse(rcl => rcl.GetJson<SpectacleInfo>($"http://Spectacles:8080/spectacles/{id}"));
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

    private const string _url = @"http://Repertoire:1001";
}