using System;
using System.Collections.Generic;

namespace Authentication.Storage.Models;

public partial class State
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ticket> Ticket { get; set; } = new List<Ticket>();
}
