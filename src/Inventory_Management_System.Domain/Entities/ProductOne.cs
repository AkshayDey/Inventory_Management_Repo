using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ProductOne
{
    public long ProductId { get; set; }

    public string? ProductName { get; set; }

    public bool? Status { get; set; }

    public string? Remarks { get; set; }

    public long? WarehouseId { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Model { get; set; }

    public string? Barcode { get; set; }

    public string? Category { get; set; }
}
