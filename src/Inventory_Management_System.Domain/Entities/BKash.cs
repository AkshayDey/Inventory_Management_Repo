using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class BKash
{
    public long BKashId { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountType { get; set; }

    public bool? Status { get; set; }

    public string? Remarks { get; set; }

    public long? WarehouseId { get; set; }
}
