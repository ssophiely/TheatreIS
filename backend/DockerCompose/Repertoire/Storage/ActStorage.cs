using Exceptions;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using Repertoire.Interaction.In;
using Repertoire.Interaction.Out;
using SharedUtils;
using StorageData;
using System.Security.Cryptography.Xml;

namespace Repertoire.Storage;

public class ActStorage
{
    public ActStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public void Delete(int id)
    {
        var act = _dbContext.Act.FirstOrDefault(r => r.Id == id)
            ?? throw new NotFoundException($"Показ с id {id} не найден");

        _dbContext.Act.Remove(act);

        _dbContext.SaveChanges();
    }

    public List<ActInfo> Get(int id)
    {
        var acts = _dbContext.Act.Include(a => a.Repertoire).AsNoTracking().Where(r => r.RepertoireId == id);

        List<ActInfo> list = [];

        foreach (var act in acts)
        {
            var info = act.Convert<ActInfo, Act>();
            info.SpectacleId = act.Repertoire.SpectacleId;

            list.Add(info);
        }

        return list;
    }

    public void Add(ActCreateInfo info)
    {
        _dbContext.Act.Add(info.Convert<Act, ActCreateInfo>());

        _dbContext.SaveChanges();
    }

    private readonly TheatreDbContext _dbContext;
}
