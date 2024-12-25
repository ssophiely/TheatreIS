namespace Tickets.Interaction.Out;

public class TicketInfo
{
    public int Id { get; set; }

    public double Rating { get; set; }

    public int ViewerId { get; set; }

    public string StateName { get; set; } = null!;

    public int StateId { get; set; }

    public int Row { get; set; }

    public decimal Price { get; set; }

    public int Seat { get; set; }

    public string Sector { get; set; } = null!;

    public string SpectacleName { get; set; } = null!;

    public int LocationId { get; set; }

    public DateTime Date { get; set; }
}
