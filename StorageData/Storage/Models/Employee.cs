using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Employee
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public int Experience { get; set; }

    public string? Phone { get; set; }

    public int PositionId { get; set; }

    public virtual Position Position { get; set; } = null!;

    public virtual ICollection<Role> Role { get; set; } = new List<Role>();
}
