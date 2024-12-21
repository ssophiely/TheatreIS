using Exceptions;
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
    /// Получение информации о месте по идентификатору.
    /// </summary>
    [HttpGet("id")]
    public async Task<IActionResult> GetLocation(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var location = _storage.GetById(id);

                return Ok(location);
            });
        }
        catch (NotFoundException ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.NotFound);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
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
                var locations = _storage.GetByActId(id);

                return Ok(locations);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение статусов мест.
    /// </summary>
    [HttpGet("states")]
    public async Task<IActionResult> GetLocationStates()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var locationStates = _storage.GetLocationStates();

                return Ok(locationStates);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение секторов зала.
    /// </summary>
    [HttpGet("sectors")]
    public async Task<IActionResult> GetSectors()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var sectors = _storage.GetSectors();

                return Ok(sectors);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }


    private readonly LocationStorage _storage;
}
