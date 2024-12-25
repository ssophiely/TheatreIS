﻿using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Auditoriumsector
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
