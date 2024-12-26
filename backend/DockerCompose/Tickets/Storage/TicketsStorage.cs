using Exceptions;
using Microsoft.EntityFrameworkCore;
using SharedUtils;
using StorageData;
using Tickets.Interaction.In;
using Tickets.Interaction.Out;

namespace Tickets.Storage;

public class TicketsStorage
{
    public TicketsStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public void CreateTicket(TicketCreateinfo info)
    {
        _dbContext.Ticket.Add(info.Convert<Ticket, TicketCreateinfo>());

        _dbContext.SaveChanges();
    }

    public void ChangeState(TicketStateChangeInfo info)
    {
        var ticket = _dbContext.Ticket.Include(s => s.State).FirstOrDefault(t => t.Id == info.Id)
            ?? throw new NotFoundException($"Билет с id {info.Id} не найден");

        ticket.StateId = info.StateId;

        _dbContext.SaveChanges();
    }

    public List<Ticket> GetByViewerId(int id)
    {
        return _dbContext.Ticket.Include(t => t.State).Include(t => t.Location).ThenInclude(l => l.Sector)
            .AsNoTracking().Where(t => t.ViewerId == id).ToList();
    }

    public List<StateInfo> GetStates()
    {
        var states = _dbContext.State.AsNoTracking();

        return [.. states.Select(s => s.Convert<StateInfo, State>())];
    }

    public void SetRate(TicketRateInfo info)
    {
        var ticket = _dbContext.Ticket.FirstOrDefault(t => t.Id == info.Id)
           ?? throw new NotFoundException($"Билет с id {info.Id} не найден");

        ticket.Rating = info.Rating;

        _dbContext.SaveChanges();
    }


    private readonly TheatreDbContext _dbContext;
}
