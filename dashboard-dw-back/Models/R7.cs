using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models
{
    public partial class R7
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int FedDistrId { get; set; }
        public int Year { get; set; }
        public int? R7catId { get; set; }
        public int? RowNumber { get; set; }
        public string? Dim { get; set; }
        public long? Val { get; set; }
    }
}
