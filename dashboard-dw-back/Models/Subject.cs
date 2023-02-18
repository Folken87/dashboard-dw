using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models;

public partial class Subject
{
    /// <summary>
    /// Номер региона
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название субъекта РФ
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Идентификатор фед. округа
    /// </summary>
    public int FedDistrictId { get; set; }

    public virtual FederalDistrict FedDistrict { get; set; } = null!;
}
