using Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tickets.Interaction.In;
using Tickets.Storage;

namespace Tickets.Controllers;

[ApiController]
[Route("tickets")]
public class TicketsController : ControllerBase
{
    public TicketsController(TicketsStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Создание билета.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateTicket(TicketCreateinfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.CreateTicket(info);

                return Ok();
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Изменение статуса билета.
    /// </summary>
    [HttpPut("state")]
    public async Task<IActionResult> ChangeTicketState(TicketStateChangeInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.ChangeState(info);

                return Ok();
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
    /// Получение билетов по идентификатору зрителя.
    /// </summary>
    [HttpGet("viewer/id")]
    public async Task<IActionResult> GetByViewerId(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var tickets = _storage.GetByViewerId(id);

                return Ok(tickets);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение статусов.
    /// </summary>
    [HttpGet("states")]
    public async Task<IActionResult> GetStates()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var states = _storage.GetStates();

                return Ok(states);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение рейтингов из билета.
    /// </summary>
    [HttpPut("rate")]
    public async Task<IActionResult> SetRate(TicketRateInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.SetRate(info);

                return Ok();
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

    private readonly TicketsStorage _storage;
}
