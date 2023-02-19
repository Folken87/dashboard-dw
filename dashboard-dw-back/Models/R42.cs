using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models
{
    public partial class R42
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int FedDistrId { get; set; }
        public int Year { get; set; }
        public string Category { get; set; } = null!;
        public int? CountUnionSch { get; set; }
        public int? CountUnionSpo { get; set; }
        public int? CountUnionHs { get; set; }
        public int? CountUnionSchMembers { get; set; }
        public int? CountUnionSpomembers { get; set; }
        public int? CountUnionHsmembers { get; set; }
        public int RowNumber { get; set; }
    }
}
