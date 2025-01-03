namespace ManagingTheatreApp.Interaction;

public class RepInfo
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public double Rating { get; set; }

    public int BoxOffice { get; set; }

    public int SpectacleId { get; set; }

    public SpectacleInfo Spectacle { get; set; } = null!;

    public List<ActInfo> Acts { get; set; } = new List<ActInfo>();
}

public class ActInfo
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int RepertoireId { get; set; }

    public int SpectacleId { get; set; }
}