using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ProductNameTwo
{
    public long ProductNameId { get; set; }

    public string? ProductName { get; set; }

    public long? WarehouseId { get; set; }
}
