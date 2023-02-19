using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models
{
    public partial class R2
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int FedDistrictId { get; set; }
        public int Year { get; set; }
        public int R2subCatId { get; set; }
        public int RowNumber { get; set; }
        public int? CountStruct { get; set; }
        public int? CountWorkers { get; set; }
        public int? CountWorkersHs { get; set; }
        public long? CountFinValue { get; set; }
        public long? CostsEvents { get; set; }
        public long? CostsAdm { get; set; }
        public long? CostsRepair { get; set; }
        public int? R2catId { get; set; }
    }
}
