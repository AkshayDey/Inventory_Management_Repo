using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class CustomerLedgerTwo
{
    public long CustomerLedgerId { get; set; }

    public long? CustomerId { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public DateTime? EntryDate { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? SalesAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? ClosingBalance { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Remarks { get; set; }

    public long? WarehouseId { get; set; }

    public long? UserId { get; set; }

    public DateOnly? LastDuePaymentDate { get; set; }
}
