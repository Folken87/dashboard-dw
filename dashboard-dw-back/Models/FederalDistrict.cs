using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models;

public partial class FederalDistrict
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<R4> R4s { get; } = new List<R4>();

    public virtual ICollection<Subject> Subjects { get; } = new List<Subject>();
}
