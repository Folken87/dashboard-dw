using System;
using System.Collections.Generic;

namespace dashboard_dw_back.Models;

public partial class R4
{
    /// <summary>
    /// внутренний идентификатор
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// идентификатор региона
    /// </summary>
    public int SubjectId { get; set; }

    /// <summary>
    /// идентификатор округа
    /// </summary>
    public int FedDistrictId { get; set; }

    /// <summary>
    /// год
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// идентификатор категории
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// номер строки
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

    public virtual R4Category Category { get; set; } = null!;

    public virtual FederalDistrict FedDistrict { get; set; } = null!;
}
