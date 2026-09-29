using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SalesmanTarget
{
    public long SalesmanTargetId { get; set; }

    public long? SalesmanId { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? Month { get; set; }

    public string? Remarks { get; set; }
}
