using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class Warehouse
{
    public long WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public decimal? WarehouseCapacity { get; set; }

    public string? Code { get; set; }

    public decimal? AssetProductValue { get; set; }

    public decimal? CashInHand { get; set; }
}
