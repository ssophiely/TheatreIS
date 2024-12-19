using System;
using System.Collections.Generic;

namespace StorageData;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int EmployeeId { get; set; }

    public int SpectacleId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Spectacle Spectacle { get; set; } = null!;
}
