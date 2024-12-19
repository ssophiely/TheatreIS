using System;
using System.Collections.Generic;

namespace Authentication.Storage.Models;

public partial class Position
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();
}
