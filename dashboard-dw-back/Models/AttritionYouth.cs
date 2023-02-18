using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models
{
    public partial class AttritionYouth
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public double? AllMember { get; set; }
        public double EmployableMembers { get; set; }
        public double? PartEmployableMembers { get; set; }
        public double? YoungCount { get; set; }
        public double? PartYoungCount { get; set; }
        public int? AttritionOtherDistrict { get; set; }
        public int? AttritionOtherCountries { get; set; }
        public int? AttritionWorkers { get; set; }
        public double? AttritionThousand { get; set; }
        public double? PartAttritionWorkers { get; set; }
        public double? AttritionYoung { get; set; }
        public double? PartAttritionYoung { get; set; }
    }
}
