using Exceptions;
using Microsoft.EntityFrameworkCore;
using Repertoire.Interaction.In;
using Repertoire.Interaction.Out;
using SharedUtils;
using StorageData;

namespace Repertoire.Storage;

public class RepertoireStorage
{
    public RepertoireStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public void Delete(int id)
    {
        var rep = _dbContext.Repertoire.FirstOrDefault(r => r.Id == id)
            ?? throw new NotFoundException($"Репертуар с id {id} не найден");

        _dbContext.Repertoire.Remove(rep);

        _dbContext.SaveChanges();
    }

    public void Add(RepertoireAddInfo info)
    {
        _dbContext.Repertoire.Add(info.Convert<StorageData.Repertoire, RepertoireAddInfo>());

        _dbContext.SaveChanges();
    }

    public List<RepertoireInfo> GetByDate(DateTime date)
    {
        var reps = _dbContext.Repertoire.Include(r => r.Spectacle).Include(r => r.Act).AsNoTracking().Where(r => r.Date == date);

        List<RepertoireInfo> list = [];

        foreach (var rep in reps)
        {
            var repInfo = rep.Convert<RepertoireInfo, StorageData.Repertoire>();

            repInfo.SpectacleName = rep.Spectacle.Name;
            repInfo.Acts = rep.Act.Select(a => a.Convert<ActInfo, Act>()).ToList();

            list.Add(repInfo);
        }

        return list;
    }

    private readonly TheatreDbContext _dbContext;
}
