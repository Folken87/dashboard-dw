namespace dashboard_dw_back.ViewModels
{
    /// <summary>
    /// Viewmodel для данных по разделу 7 - Вовлеченность в волонтёрство
    /// </summary>
    public class R7View
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
        public int? R7CatId { get; set; }

        /// <summary>
        /// Имя категории
        /// </summary>
        public string? R7CatName { get; set; }

        /// <summary>
        /// Идентификатор родительской категории-агрегатора
        /// </summary>
        public int? R7SubCatId { get; set; }

        /// <summary>
        /// Имя родительской категории-агрегатора
        /// </summary>
        public string? R7SubCatName { get; set; }

        /// <summary>
        /// Номер строки
        /// </summary>
        public int? RowNumber { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public string? Dim { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public long? Val { get; set; }
    }
}
