using System.ComponentModel.DataAnnotations.Schema;

namespace dashboard_dw_back.ViewModels
{
    /// <summary>
    /// Viewmodel для данных по 1 разделу - Распределение бюджетов по направлениям молодёжной политики млн руб.
    /// </summary>
    public class R1View
    {
        /// <summary>
        /// Внутренний идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Номер субъекта РФ
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// Название субъекта РФ
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// Идентификатор фед. округа
        /// </summary>
        public int FedDistrId { get; set; }

        /// <summary>
        /// Название фед. округа
        /// </summary>
        public string FedDistrName { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Идентификатор категории
        /// </summary>
        [Column("R2CatId")]
        public int R1CatId { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string R1CatName { get; set; }

        /// <summary>
        /// Идентификатор сабкатегории
        /// </summary>
        public int? R1SubCatId { get; set; }

        /// <summary>
        /// Название сабкатегории
        /// </summary>
        public string? R1SubCatName { get; set; }

        /// <summary>
        /// Номер строки
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// Бюджет СРФ, руб
        /// </summary>
        public double? BudgetSRF { get; set; }

        /// <summary>
        /// Бюджет МО, руб
        /// </summary>
        public double? BudgetMO { get; set; }

        /// <summary>
        /// Кол-во грантов
        /// </summary>
        public int? CountGrant { get; set; }

        /// <summary>
        /// Бюджет грантов, руб
        /// </summary>
        public double? BudgetGrant { get; set; }

        /// <summary>
        /// Численность молодeжи, задействованной в программных мероприятиях по направлению
        /// </summary>
        public int? CountEventMember { get; set; }

        /// <summary>
        /// Количество детских и молодeжных общественных объединений, работающих по данному
        /// </summary>
        public int? CountChildCompany { get; set; }
    }
}
