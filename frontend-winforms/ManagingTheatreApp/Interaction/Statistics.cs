namespace ManagingTheatreApp.Interaction;

public class SoldTicketsMonth
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public long TicketsCount { get; set; }
}

public class SpectaclesBoxofficeYear
{
    public string Name { get; set; } = null!;

    public decimal? TotalBoxOffice { get; set; }
}