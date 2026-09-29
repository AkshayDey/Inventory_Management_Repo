using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class ChequeOne
{
    public long ChequeId { get; set; }

    public string? ChequeNumber { get; set; }

    public DateTime? ChequeDate { get; set; }

    public bool? CashPaidInstead { get; set; }

    public string? NewChequeNumber { get; set; }

    public bool? CashIn { get; set; }

    public bool? BankIn { get; set; }

    public string? InvoiceNo { get; set; }

    public bool? ChequeBounced { get; set; }

    public bool? ShowChequeInfo { get; set; }

    public bool? NewChequeSendInstead { get; set; }

    public bool? ChequeCancel { get; set; }

    public decimal? Amount { get; set; }

    public long? BankId { get; set; }

    public string? BankAndBranchName { get; set; }

    public string? AccountHolderName { get; set; }

    public long? WarehouseId { get; set; }

    public string? Type { get; set; }

    public long? SalesmanId { get; set; }

    public DateOnly? ChequeOutDate { get; set; }
}
