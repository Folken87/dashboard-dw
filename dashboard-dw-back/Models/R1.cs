using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models
{
    public partial class R1
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int FedDistrId { get; set; }
        public int Year { get; set; }
        public int R2catId { get; set; }
        public int RowNumber { get; set; }
        public double? BudgetSrf { get; set; }
        public double? BudgetMo { get; set; }
        public int? CountGrant { get; set; }
        public double? BudgetGrant { get; set; }
        public int? CountEventMember { get; set; }
        public int? CountChildCompany { get; set; }
    }
}
