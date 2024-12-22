using System;
using System.Collections.Generic;

namespace StorageData;

public partial class ViewerGenreVisits
{
    public int ViewerId { get; set; }

    public int GenreId { get; set; }

    public long VisitCount { get; set; }
}
