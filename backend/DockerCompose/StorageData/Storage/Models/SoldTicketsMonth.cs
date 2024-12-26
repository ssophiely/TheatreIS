using System;
using System.Collections.Generic;

namespace StorageData;

public partial class SoldTicketsMonth
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public long TicketsCount { get; set; }
}
