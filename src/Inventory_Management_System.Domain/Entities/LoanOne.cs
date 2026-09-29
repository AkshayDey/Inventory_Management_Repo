using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class LoanOne
{
    public long LoanId { get; set; }

    public long? LoanSectorId { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? Amount { get; set; }

    public decimal? ClosingBalance { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Remarks { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Type { get; set; }

    public long? WarehouseId { get; set; }
}
