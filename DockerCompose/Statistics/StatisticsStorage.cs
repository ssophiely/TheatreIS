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

    public List<ViewerGenreVisits> GetGenreVisits()
    {
        return [.. _dbContext.ViewerGenreVisits];
    }

    public List<SumHoursWatching> GetHoursWatching()
    {
        return [.. _dbContext.SumHoursWatching];
    }


    private readonly TheatreDbContext _dbContext;
}
