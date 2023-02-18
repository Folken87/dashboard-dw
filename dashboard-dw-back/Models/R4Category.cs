using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models;

public partial class R4Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<R4> R4s { get; } = new List<R4>();
}
