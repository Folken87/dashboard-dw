using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models;

public partial class R4
{
    public int Id { get; set; }

    public int SubjectId { get; set; }

    public int FedDistrictId { get; set; }

    public int Year { get; set; }

    public int CategoryId { get; set; }

    public int RowNumber { get; set; }

    public int? CountReg { get; set; }

    public int? CountMunicip { get; set; }

    public int? CountMembersReg { get; set; }

    public int? CountMembersMunicip { get; set; }

    public int? CountPartReg { get; set; }

    public int? CountPartMunicip { get; set; }

    public int? FinReg { get; set; }

    public int? FinMunicip { get; set; }

    public virtual R4Category Category { get; set; } = null!;

    public virtual FederalDistrict FedDistrict { get; set; } = null!;
}
