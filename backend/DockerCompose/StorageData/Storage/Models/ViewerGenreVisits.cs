using System;
using System.Collections.Generic;

namespace StorageData;

public partial class ViewerGenreVisits
{
    public int ViewerId { get; set; }

    public string GenreName { get; set; } = null!;

    public long VisitCount { get; set; }
}
