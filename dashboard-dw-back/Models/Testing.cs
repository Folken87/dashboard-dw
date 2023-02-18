using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models;

public partial class Testing
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Desc { get; set; } = null!;
}
