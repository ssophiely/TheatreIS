using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Statistics.Controllers;

[ApiController]
[Route("statistics/admin")]
public class AdminStatisticsController : ControllerBase
{
    public AdminStatisticsController(StatisticsStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Получение количества проданных билетов за каждый месяц.
    /// </summary>
    [HttpGet("sold-tickets")]
    public async Task<IActionResult> GetSoldTicketsPerMonth()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetSoldTickets();

                return Ok(info);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение суммы кассовых сборов по спектаклям за текущий год.
    /// </summary>
    [HttpGet("boxoffice")]
    public async Task<IActionResult> GetYearSpectaclesBoxOffice()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetBoxOffice();

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
