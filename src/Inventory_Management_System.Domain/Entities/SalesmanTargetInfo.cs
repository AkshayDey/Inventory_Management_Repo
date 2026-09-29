using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SalesmanTargetInfo
{
    public long SalesmanTargetInfoId { get; set; }

    public long? SalesmanId { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? OrderAmount { get; set; }

    public decimal? PaidAmount { get; set; }
}
