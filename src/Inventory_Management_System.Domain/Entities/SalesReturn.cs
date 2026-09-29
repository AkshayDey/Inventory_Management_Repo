using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SalesReturn
{
    public long SalesReturnId { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime ReturnDate { get; set; }

    public int UserId { get; set; }

    public string? Remarks { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? EntryDate { get; set; }
}
