using dashboard_dw_back.Models;

namespace dashboard_dw_back.ViewModels
{
    public class R4ViewModel
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string FedDistrict { get; set; }

        public int Year { get; set; }

        public string CategoryName { get; set; }

        public int RowNumber { get; set; }

        public int? CountReg { get; set; }

        public int? CountMunicip { get; set; }

        public int? CountMembersReg { get; set; }

        public int? CountMembersMunicip { get; set; }

        public int? CountPartReg { get; set; }

        public int? CountPartMunicip { get; set; }

        public int? FinReg { get; set; }

        public int? FinMunicip { get; set; }
    }
}
