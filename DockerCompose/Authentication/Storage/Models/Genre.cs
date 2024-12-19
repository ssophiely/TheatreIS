using System;
using System.Collections.Generic;

namespace Authentication.Storage.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Spectacle> Spectacle { get; set; } = new List<Spectacle>();
}
