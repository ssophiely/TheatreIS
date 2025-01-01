using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Spectacle
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Duration { get; set; }

    public string? Plot { get; set; }

    public int GenreId { get; set; }

    public virtual Genre Genre { get; set; } = null!;

    public virtual ICollection<Repertoire> Repertoire { get; set; } = new List<Repertoire>();

    public virtual ICollection<Role> Role { get; set; } = new List<Role>();
}
