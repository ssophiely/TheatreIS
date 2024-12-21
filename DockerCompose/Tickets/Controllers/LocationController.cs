using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tickets.Storage;

namespace Tickets.Controllers;

[Route("location")]
[ApiController]
public class LocationController : ControllerBase
{
    public LocationController(LocationStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Получение информации о местах по идентификатору показа.
    /// </summary>
    [HttpGet("act/id")]
    public async Task<IActionResult> GetLocations(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var locations = _storage.Get(id);

                return Ok(locations);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }


    private readonly LocationStorage _storage;
}
