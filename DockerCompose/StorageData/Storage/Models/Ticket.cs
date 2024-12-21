using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Ticket
{
    public int Id { get; set; }

    public double Rating { get; set; }

    public int ViewerId { get; set; }

    public int StateId { get; set; }

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual State State { get; set; } = null!;

    public virtual Viewer Viewer { get; set; } = null!;
}
