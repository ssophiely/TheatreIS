namespace ManagingTheatreApp.Interaction.Out;

public class CreateRole
{
    public string Name { get; set; } = null!;

    public int EmployeeId { get; set; }

    public int SpectacleId { get; set; }
}
