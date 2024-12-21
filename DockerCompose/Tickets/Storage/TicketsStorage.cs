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

    public List<TicketInfo> GetByViewerId(int id)
    {
        var tickets = _dbContext.Ticket.AsNoTracking().Where(t => t.ViewerId == id);

        return [.. tickets.Select(t => t.Convert<TicketInfo, Ticket>())];
    }

    public List<StateInfo> GetStates()
    {
        var states = _dbContext.State.AsNoTracking();

        return [.. states.Select(s => s.Convert<StateInfo, State>())];
    }


    private readonly TheatreDbContext _dbContext;
}
