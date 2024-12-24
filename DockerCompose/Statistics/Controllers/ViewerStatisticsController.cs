using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Statistics.Controllers;

[ApiController]
[Route("statistics/viewer")]
[Authorize]
public class ViewerStatisticsController : ControllerBase
{
    public ViewerStatisticsController(StatisticsStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Получение количества посещений по жанрам.
    /// </summary>
    [HttpGet("genre-visits/{id}")]
    public async Task<IActionResult> GetGenreVisits(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetGenreVisits(id);

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
    [HttpGet("hours-watching/{id}")]
    public async Task<IActionResult> GetHoursWatching(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetHoursWatching(id);

                return Ok(info);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Число купленных билетов.
    /// </summary>
    [HttpGet("bought-tickets/{id}")]
    public async Task<IActionResult> GetTickets(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetTickets(id);

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
