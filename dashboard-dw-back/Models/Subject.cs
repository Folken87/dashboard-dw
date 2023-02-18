using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int FedDistrictId { get; set; }

    public virtual FederalDistrict FedDistrict { get; set; } = null!;
}
