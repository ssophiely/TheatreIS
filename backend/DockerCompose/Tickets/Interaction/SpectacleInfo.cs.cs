namespace Tickets.Interaction;

public class SpectacleInfo
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Duration { get; set; }

    public string? Plot { get; set; }

    public string Genre { get; set; } = null!;

    public List<SpecRole> Role { get; set; } = new List<SpecRole>();
}

public class SpecRole
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int EmployeeId { get; set; }

    public string EmpName { get; set; } = null!;

}
