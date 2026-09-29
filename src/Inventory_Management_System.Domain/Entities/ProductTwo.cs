using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ProductTwo
{
    public long ProductId { get; set; }

    public long? ProductNameId { get; set; }

    public bool? Status { get; set; }

    public string? Remarks { get; set; }

    public long? WarehouseId { get; set; }

    public string? ModelName { get; set; }
}
