using System.ComponentModel.DataAnnotations.Schema;

namespace dashboard_dw_back.ViewModels
{
    public class AttritionYouthView
    {
        /// <summary>
        /// внутренний идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// номер региона
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// общее население, тыс. чел.
        /// </summary>
        public double? AllMember { get; set; }

        /// <summary>
        /// трудоспособное население, тыс. ч
        /// </summary>
        public double EmployableMembers { get; set; }

        /// <summary>
        /// процент трудоспособного населения (умножить на 100)
        /// </summary>
        public double? PartEmployableMembers { get; set; }

        /// <summary>
        /// Количество молодёжи 14-35 лет (расчётное), тыс. чел.
        /// </summary>
        public double? YoungCount { get; set; }

        /// <summary>
        /// процент молодёжи от трудоспособного населения (умножить на 100)
        /// </summary>
        public double? PartYoungCount { get; set; }

        /// <summary>
        /// выбывшие в другие регионы, трудоспособное население, чел.
        /// </summary>
        public int? AttritionOtherDistrict { get; set; }

        /// <summary>
        /// выбывшие в другие страны, трудоспособное население, чел.
        /// </summary>
        public int? AttritionOtherCountries { get; set; }

        /// <summary>
        /// Выбывшие трудоспособные в сумме, чел.
        /// </summary>
        public int? AttritionWorkers { get; set; }

        /// <summary>
        /// Выбывшие трудоспособные в сумме на тысячу
        /// </summary>
        public double? AttritionThousand { get; set; }

        /// <summary>
        /// Выбывшие трудоспособные процент от трудоспособного населения (умножить на 100)
        /// </summary>
        public double? PartAttritionWorkers { get; set; }

        /// <summary>
        /// Выбывшая молодежь, тыс. чел.
        /// </summary>
        public double? AttritionYoung { get; set; }

        /// <summary>
        /// Процент выбывшей молодежи (умножить на 100)
        /// </summary>
        public double? PartAttritionYoung { get; set; }

        /// <summary>
        /// название региона
        /// </summary>
        [Column("Name")]
        public string SubjectName { get; set; }
    }
}
