using Exceptions;
using SharedUtils;
using StorageData;
using Tickets.Interaction.Out;

namespace Tickets.Storage;

public class LocationStorage
{
    public LocationStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public LocationInfo GetById(int id)
    {
        var location = _dbContext.Location.FirstOrDefault(l => l.Id == id)
            ?? throw new NotFoundException($"Место с id {id} не найденj"); ;

        return location.Convert<LocationInfo, Location>();
    }

    public List<LocationInfo> GetByActId(int id)
    {
        var locations = _dbContext.Location.Where(l => l.ActId == id);

        return [.. locations.Select(l => l.Convert<LocationInfo, Location>())];
    }

    public List<LocationStateInfo> GetLocationStates()
    {
        var locationStates = _dbContext.LocationState;

        return [.. locationStates.Select(l => l.Convert<LocationStateInfo, LocationState>())];
    }

    public List<AuditoriumsectorInfo> GetSectors()
    {
        var sectors = _dbContext.Auditoriumsector;

        return [.. sectors.Select(l => l.Convert<AuditoriumsectorInfo, Auditoriumsector>())];
    }



    private readonly TheatreDbContext _dbContext;
}
