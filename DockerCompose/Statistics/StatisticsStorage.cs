using Microsoft.EntityFrameworkCore;
using StorageData;

namespace Statistics;

public class StatisticsStorage
{
    public StatisticsStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public List<SoldTicketsMonth> GetSoldTickets()
    {
        return [.. _dbContext.SoldTicketsMonth];
    }

    public List<SpectaclesBoxofficeYear> GetBoxOffice()
    {
        return [.. _dbContext.SpectaclesBoxofficeYear];
    }

    public List<ViewerGenreVisits> GetGenreVisits(int id)
    {
        return [.. _dbContext.ViewerGenreVisits.AsNoTracking().Where(v=>v.ViewerId==id)];
    }

    public List<SumHoursWatching> GetHoursWatching(int id)
    {
        return [.. _dbContext.SumHoursWatching.AsNoTracking().Where(v => v.ViewerId == id)];
    }

    public List<BoughtTickets> GetTickets(int id)
    {
        return [.. _dbContext.BoughtTickets.AsNoTracking().Where(v => v.ViewerId == id)];
    }


    private readonly TheatreDbContext _dbContext;
}
