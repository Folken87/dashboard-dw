namespace dashboard_dw_back.ViewModels
{
    /// <summary>
    /// Viewmodel для данных по разделу 4-2 - Вовлеченность учащихся в общественные объединения шт
    /// </summary>
    public class R4_2View
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
        /// Категория
        /// </summary>
        public string Category { get; set; } = null!;

        /// <summary>
        /// Номер строки
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// Кол-во общ.объед.школ
        /// </summary>
        public int? CountUnionSch { get; set; }

        /// <summary>
        /// Кол-во общ.объед.СПО
        /// </summary>
        public int? CountUnionSPO { get; set; }

        /// <summary>
        /// Кол-во общ.объед.вузов
        /// </summary>
        public int? CountUnionHS { get; set; }

        /// <summary>
        /// Число уч-в общ.объед.школ
        /// </summary>
        public int? CountUnionSchMembers { get; set; }

        /// <summary>
        /// Число уч-в общ.объед.СПО
        /// </summary>
        public int? CountUnionSPOMembers { get; set; }

        /// <summary>
        /// Число уч-в общ.объед.вузов
        /// </summary>
        public int? CountUnionHSMembers { get; set; }
    }
}
