using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models
{
    public partial class R6
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int FedDictId { get; set; }
        public int Year { get; set; }
        public int R6catId { get; set; }
        public int RowNumber { get; set; }
        public int? CountForum { get; set; }
        public long? CountMemberForum { get; set; }
        public double? FinRegVal { get; set; }
        public double? FinMunVal { get; set; }
    }
}
