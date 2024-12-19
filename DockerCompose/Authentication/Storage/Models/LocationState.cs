using System;
using System.Collections.Generic;

namespace Authentication.Storage.Models;

public partial class LocationState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Location> Location { get; set; } = new List<Location>();
}
