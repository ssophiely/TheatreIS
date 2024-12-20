using Microsoft.EntityFrameworkCore;
using Spectacles.Interaction.Out;
using StorageData;

namespace Spectacles.Storage;

public class EmpStorage
{
    public EmpStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public List<EmployeeInfo> GetEmployees()
    {
        var emps = _dbContext.Employee.Include(e => e.Position).Include(e => e.Role).ThenInclude(r => r.Spectacle).AsNoTracking();

        List<EmployeeInfo> list = [];

        foreach (var emp in emps)
        {
            List<RoleInfo> roles = [];

            foreach (var role in emp.Role)
            {
                roles.Add(new RoleInfo()
                {
                    Name = role.Name,
                    Spectacle = role.Spectacle.Name,
                });
            }

            list.Add(new EmployeeInfo()
            {
                FullName = emp.FullName,
                Experience = emp.Experience,
                Phone = emp.Phone,
                Position = emp.Position.Name,
                Role = roles
            });
        }

        return list;
    }

    private readonly TheatreDbContext _dbContext;
}
