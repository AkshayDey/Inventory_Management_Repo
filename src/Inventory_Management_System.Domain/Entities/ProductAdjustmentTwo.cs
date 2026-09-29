using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ProductAdjustmentTwo
{
    public long ProductAdjustmentId { get; set; }

    public long? ProductId { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? EntryDate { get; set; }

    public decimal? Quantity { get; set; }

    public string? Remarks { get; set; }
}
