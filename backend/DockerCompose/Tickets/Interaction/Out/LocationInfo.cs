using StorageData;

namespace Tickets.Interaction.Out;

public class LocationInfo
{
    public int Id { get; set; }

    public int Row { get; set; }

    public decimal Price { get; set; }

    public int Seat { get; set; }

    public int? SectorId { get; set; }

    public string Sector { get; set; } = null!;

    public string State { get; set; } = null!;

    public int? LocationStateId { get; set; }

    public int? ActId { get; set; }
}
