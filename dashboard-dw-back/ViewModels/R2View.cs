namespace dashboard_dw_back.ViewModels
{
    public class R2View
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
        public int FedDistrictId { get; set; }

        /// <summary>
        /// Название фед. округа
        /// </summary>
        public string FedDistrictName { get; set; } 

        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int? R2CatId { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string R2CatName { get; set; }

        /// <summary>
        /// Название субкатегории
        /// </summary>
        public string R2SubCatName { get; set; }

        /// <summary>
        /// Идентификатор субкатегории
        /// </summary>
        public int R2SubCatId { get; set; }

        /// <summary>
        /// Номер строки
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// Кол-во структур, ед
        /// </summary>
        public int? CountStruct { get; set; }

        /// <summary>
        /// Всего кол-во сотрудников, чел
        /// </summary>
        public int? CountWorkers { get; set; }

        /// <summary>
        /// Всего с профильным образованием
        /// </summary>
        public int? CountWorkersHS { get; set; }

        /// <summary>
        /// Всего объeм финансирования, руб
        /// </summary>
        public long? CountFinValue { get; set; }

        /// <summary>
        /// Расходы на мероприятия
        /// </summary>
        public long? CostsEvents { get; set; }

        /// <summary>
        /// Расходы на адм функции
        /// </summary>
        public long? CostsAdm { get; set; }

        /// <summary>
        /// Расходы на ремонт
        /// </summary>
        public long? CostsRepair { get; set; }
    }
}
