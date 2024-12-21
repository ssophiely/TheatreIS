using StorageData;

namespace Tickets.Storage;

public class LocationStorage
{
    public LocationStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }





    private readonly TheatreDbContext _dbContext;
}
