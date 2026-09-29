using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ExpenseOne
{
    public long ExpenseId { get; set; }

    public long? ExpenseSectorId { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? Date { get; set; }

    public string? Remarks { get; set; }

    public string? PaymentMethod { get; set; }

    public long? WarehouseId { get; set; }

    public DateTime? EntryDate { get; set; }
}
