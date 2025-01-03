namespace ManagingTheatreApp.Interaction.Out;

public class CreateRep
{
    public DateTime Date { get; set; }

    public List<int> SpectacleIds { get; set; } = null!;
}
