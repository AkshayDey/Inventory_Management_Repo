using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class CashAccountingTwo
{
    public long CashAccountingId { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? Amount { get; set; }

    public decimal? ClosingBalance { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Remarks { get; set; }

    public long? WarehouseId { get; set; }
}
