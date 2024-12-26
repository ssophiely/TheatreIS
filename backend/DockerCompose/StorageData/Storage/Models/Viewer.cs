using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Viewer
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string Mail { get; set; } = null!;

    public string? Phone { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<Ticket> Ticket { get; set; } = new List<Ticket>();
}
