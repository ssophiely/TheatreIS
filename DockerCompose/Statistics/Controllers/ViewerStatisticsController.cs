using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Statistics.Controllers;

[ApiController]
[Route("statistics/viewer")]
public class ViewerStatisticsController : ControllerBase
{
    public ViewerStatisticsController(StatisticsStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Получение количества посещений по жанрам.
    /// </summary>
    [HttpGet("genre-visits")]
    public async Task<IActionResult> GetGenreVisits()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetGenreVisits();

                return Ok(info);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение часов просмотра спектаклей.
    /// </summary>
    [HttpGet("hours-watching")]
    public async Task<IActionResult> GetHoursWatching()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetHoursWatching();

                return Ok(info);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    private readonly StatisticsStorage _storage;
}
