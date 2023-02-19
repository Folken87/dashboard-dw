namespace dashboard_dw_back.ViewModels
{
    /// <summary>
    /// Viewmodel для данных по разделу 6 - Вовлеченность в молодежные форумы
    /// </summary>
    public class R6View
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
        public int R6CatId { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string R6CatName { get; set; }

        /// <summary>
        /// Номер строки
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// Количество форумов соответствующего уровня, прошедших на территории субъекта РФ
        /// </summary>
        public int? CountForum { get; set; }

        /// <summary>
        /// Численность участников форумов соответствующего уровня, чел
        /// </summary>
        public long? CountMemberForum { get; set; }

        /// <summary>
        /// Объeм рег. финансирования
        /// </summary>
        public double? FinRegVal { get; set; }

        /// <summary>
        /// Объeм мун. финансирования
        /// </summary>
        public double? FinMunVal { get; set; }
    }
}
