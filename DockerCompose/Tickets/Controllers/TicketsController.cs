using Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedUtils;
using StorageData;
using System.Net;
using Tickets.Clients;
using Tickets.Interaction.In;
using Tickets.Interaction.Out;
using Tickets.Storage;

namespace Tickets.Controllers;

[ApiController]
[Route("tickets")]
public class TicketsController : ControllerBase
{
    public TicketsController(TicketsStorage storage, SpectaclesClient client, RepertoireClient repClient)
    {
        _storage = storage;
        _specClient = client;
        _repClient = repClient;
    }

    /// <summary>
    /// Создание билета.
    /// </summary>
    [HttpPost]
    [Authorize]
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
    [Authorize]
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
    [HttpGet("viewer/{id}")]
    public async Task<IActionResult> GetByViewerId(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(async () =>
            {
                var tickets = _storage.GetByViewerId(id);

                List<TicketInfo> ticketInfos = [];

                foreach (var ticket in tickets)
                {
                    TicketInfo info = ticket.Convert<TicketInfo, Ticket>();
                    Console.WriteLine("Перевели");
                    info.StateName = ticket.State.Name;
                    info.Row = ticket.Location.Row;
                    info.Seat = ticket.Location.Seat;
                    info.Price = ticket.Location.Price;
                    info.Sector = ticket.Location.Sector!.Name;

                    var actInfo = await _repClient.GetActInfo(ticket.Location.ActId);
                    Console.WriteLine(actInfo.SpectacleId);
                    var specInfo = await _specClient.GetSpectacle(actInfo.SpectacleId);
                    Console.WriteLine("Перевели2");

                    info.SpectacleName = specInfo.Name;
                    info.Date = actInfo.Date;

                    ticketInfos.Add(info);
                }

                return Ok(ticketInfos);
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
    /// Установка рейтинга.
    /// </summary>
    [HttpPut("rate")]
    [Authorize]
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

    private readonly SpectaclesClient _specClient;

    private readonly RepertoireClient _repClient;
}
