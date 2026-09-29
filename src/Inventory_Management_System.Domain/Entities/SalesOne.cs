using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class SalesOne
{
    public long SalesId { get; set; }

    public string? InvoiceNo { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? BalanceForward { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal DueAmount { get; set; }

    public DateOnly? SalesDate { get; set; }

    public DateTime? EntryDate { get; set; }

    public long? UserId { get; set; }

    public string? Remarks { get; set; }

    public long? CustomerId { get; set; }

    public string? HandInvoiceNo { get; set; }

    public long? WarehouseId { get; set; }

    public decimal? DesignCharge { get; set; }

    public string? Description { get; set; }

    public bool? IsCancel { get; set; }

    public string? CustomerMobileNo { get; set; }

    public decimal? ChangeAmount { get; set; }

    public decimal? GivenAmount { get; set; }
}
