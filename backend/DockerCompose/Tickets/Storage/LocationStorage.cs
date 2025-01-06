using Exceptions;
using Microsoft.EntityFrameworkCore;
using SharedUtils;
using StorageData;
using System.Linq;
using Tickets.Interaction.In;
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
        var location = _dbContext.Location.Include(l => l.Sector).Include(l => l.LocationState).AsNoTracking()
            .FirstOrDefault(l => l.Id == id) ?? throw new NotFoundException($"Место с id {id} не найдено");

        var res = location.Convert<LocationInfo, Location>();
        res.Sector = location.Sector!.Name;
        res.State = location.LocationState!.Name;

        return res;
    }

    public List<LocationInfo> GetByActId(int id)
    {
        var locations = _dbContext.Location.Include(l => l.Sector).Include(l => l.LocationState).Where(l => l.ActId == id).AsNoTracking();

        List<LocationInfo> res = [];

        foreach (var location in locations)
        {
            var l = location.Convert<LocationInfo, Location>();
            l.State = location.LocationState!.Name;
            l.Sector = location.Sector!.Name;
            res.Add(l);
        }

        return res;
    }

    public List<LocationStateInfo> GetLocationStates()
    {
        var locationStates = _dbContext.LocationState.AsNoTracking();

        return [.. locationStates.Select(l => l.Convert<LocationStateInfo, LocationState>())];
    }

    public List<AuditoriumsectorInfo> GetSectors()
    {
        var sectors = _dbContext.Auditoriumsector.AsNoTracking();

        return [.. sectors.Select(l => l.Convert<AuditoriumsectorInfo, Auditoriumsector>())];
    }

    public void ChangePrice(LocationPriceChange info)
    {
        var location = _dbContext.Location.FirstOrDefault(l => l.Id == info.Id)
                ?? throw new NotFoundException($"Место с id {info.Id} не найдено");

        location.Price = info.Price;

        _dbContext.SaveChanges();
    }

    private readonly TheatreDbContext _dbContext;
}
