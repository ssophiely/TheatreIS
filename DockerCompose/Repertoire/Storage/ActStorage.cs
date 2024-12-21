using Exceptions;
using Microsoft.EntityFrameworkCore;
using Repertoire.Interaction.In;
using Repertoire.Interaction.Out;
using SharedUtils;
using StorageData;

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

    public ActInfo Get(int id)
    {
        var act = _dbContext.Act.AsNoTracking().FirstOrDefault(r => r.Id == id)
            ?? throw new NotFoundException($"Показ с id {id} не найден");

        return act.Convert<ActInfo, Act>();
    }

    public void Add(ActCreateInfo info)
    {
        _dbContext.Act.Add(info.Convert<Act, ActCreateInfo>());

        _dbContext.SaveChanges();
    }

    private readonly TheatreDbContext _dbContext;
}
