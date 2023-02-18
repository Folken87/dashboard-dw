using dashboard_dw_back.Models;

namespace dashboard_dw_back.ViewModels
{
    public class R4ViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Субъект РФ
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Федеральный округ
        /// </summary>
        public string FedDistrict { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// № Строки
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// Кол-во рег. объединений, ед
        /// </summary>
        public int? CountReg { get; set; }

        /// <summary>
        /// Кол-во мест. объединений, ед
        /// </summary>
        public int? CountMunicip { get; set; }

        /// <summary>
        /// Число членов рег. объединений, чел
        /// </summary>
        public int? CountMembersReg { get; set; }

        /// <summary>
        /// Число членов мест. объединений, чел
        /// </summary>
        public int? CountMembersMunicip { get; set; }

        /// <summary>
        /// Число уч-в мер-й рег. объединений, чел
        /// </summary>
        public int? CountPartReg { get; set; }

        /// <summary>
        /// Число уч-в мер-й мест. объединений, чел
        /// </summary>
        public int? CountPartMunicip { get; set; }

        /// <summary>
        /// Объeм фин.поддержки рег. объединений, руб
        /// </summary>
        public int? FinReg { get; set; }

        /// <summary>
        /// Объeм фин.поддержки мест. объединений, руб
        /// </summary>
        public int? FinMunicip { get; set; }
    }
}
