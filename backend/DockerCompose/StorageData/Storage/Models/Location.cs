using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Location
{
    public int Id { get; set; }

    public int Row { get; set; }

    public decimal Price { get; set; }

    public int Seat { get; set; }

    public int? SectorId { get; set; }

    public int? LocationStateId { get; set; }

    public int ActId { get; set; }

    public virtual Act? Act { get; set; }

    public virtual LocationState? LocationState { get; set; }

    public virtual Auditoriumsector? Sector { get; set; }

    public virtual ICollection<Ticket> Ticket { get; set; } = new List<Ticket>();
}
