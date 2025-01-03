namespace ManagingTheatreApp.Interaction.Out;

public class CreateSpectacle
{
    public string Name { get; set; } = null!;

    public double Duration { get; set; }

    public string? Plot { get; set; }

    public int GenreId { get; set; }

    public List<RoleCreateInfo> Roles { get; set; } = null!;
}

public class RoleCreateInfo
{
    public string Name { get; set; } = null!;

    public int EmployeeId { get; set; }
}