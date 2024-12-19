using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Repertoire
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int BoxOffice { get; set; }

    public double Rating { get; set; }

    public int SpectacleId { get; set; }

    public virtual ICollection<Act> Act { get; set; } = new List<Act>();

    public virtual Spectacle Spectacle { get; set; } = null!;
}
