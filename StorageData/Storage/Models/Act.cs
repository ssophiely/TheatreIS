using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Act
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int RepertoireId { get; set; }

    public virtual ICollection<Location> Location { get; set; } = new List<Location>();

    public virtual Repertoire Repertoire { get; set; } = null!;
}
