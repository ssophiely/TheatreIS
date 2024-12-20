using Exceptions;
using Microsoft.EntityFrameworkCore;
using SharedUtils;
using Spectacles.Interaction.In;
using Spectacles.Interaction.Out;
using StorageData;

namespace Spectacles.Storage;

public class SpectacleStorage
{
    public SpectacleStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public List<SpectacleInfo> GetAll()
    {
        var spectacles = _dbContext.Spectacle.Include(s => s.Genre).Include(s => s.Role).ThenInclude(r => r.Employee).AsNoTracking();

        List<SpectacleInfo> list = [];

        foreach (var s in spectacles)
        {
            List<SpecRole> roles = [];

            foreach (var role in s.Role)
            {
                roles.Add(new SpecRole()
                {
                    Id = role.Id,
                    Name = role.Name,
                    EmployeeId = role.EmployeeId,
                    EmpName = role.Employee.FullName
                });
            }

            list.Add(new SpectacleInfo()
            {
                Id = s.Id,
                Name = s.Name,
                Duration = s.Duration,
                Plot = s.Plot,
                Genre = s.Genre.Name,
                Role = roles
            });
        }

        return list;
    }

    public SpectacleInfo GetSpectacle(int id)
    {
        var spectacle = _dbContext.Spectacle.Include(s => s.Genre).Include(s => s.Role).ThenInclude(r => r.Employee)
            .AsNoTracking().FirstOrDefault(s => s.Id == id) ?? throw new NotFoundException($"Спектакль с id {id} не найден");

        List<SpecRole> roles = [];

        foreach (var role in spectacle.Role)
        {
            roles.Add(new SpecRole()
            {
                Id = role.Id,
                Name = role.Name,
                EmployeeId = role.EmployeeId,
                EmpName = role.Employee.FullName
            });
        }

        SpectacleInfo info = new SpectacleInfo()
        {
            Id = spectacle.Id,
            Name = spectacle.Name,
            Duration = spectacle.Duration,
            Plot = spectacle.Plot,
            Genre = spectacle.Genre.Name,
            Role = roles
        };

        return info;
    }


    public void DeleteSpectacle(int id)
    {
        var spectacle = _dbContext.Spectacle.Include(s => s.Role).AsNoTracking().FirstOrDefault(s => s.Id == id)
            ?? throw new NotFoundException($"Спектакль с id {id} не найден");

        _dbContext.Spectacle.Remove(spectacle);

        foreach (var role in spectacle.Role)
        {
            _dbContext.Role.Remove(role);
        }

        _dbContext.SaveChanges();
    }

    public void CreateSpectacle(SpectacleCreateInfo info)
    {
        List<Role> roles = [];

        foreach (var role in info.Roles)
        {
            roles.Add(new Role()
            {
                Name = role.Name,
                EmployeeId = role.EmployeeId,
            });
        }

        var newSpectacle = new Spectacle()
        {
            Name = info.Name,
            Duration = info.Duration,
            Plot = info.Plot,
            GenreId = info.GenreId,
            Role = roles
        };
    }

    public void UpdateSpectacle(int id, SpectacleUpdateInfo info)
    {
        var spectacle = _dbContext.Spectacle.Include(s => s.Genre).FirstOrDefault(s => s.Id == id)
            ?? throw new NotFoundException($"Спектакль с id {id} не найден");

        spectacle.UpdateObject(info);

        _dbContext.SaveChanges();
    }

    public void AddRole(RoleAddInfo info)
    {
        var role = info.Convert<Role, RoleAddInfo>();

        _dbContext.Role.Add(role);

        _dbContext.SaveChanges();
    }

    public void DeleteRole(int id)
    {
        var role = _dbContext.Role.FirstOrDefault(r => r.Id == id)
            ?? throw new NotFoundException($"Роль с id {id} не найдена");

        _dbContext.Role.Remove(role);

        _dbContext.SaveChanges();
    }

    public void ChangeRole(int id, RoleUpdateInfo info)
    {
        var role = _dbContext.Role.FirstOrDefault(r => r.Id == id)
            ?? throw new NotFoundException($"Роль с id {id} не найдена");

        role.UpdateObject(info);

        _dbContext.SaveChanges();
    }




    private readonly TheatreDbContext _dbContext;
}
