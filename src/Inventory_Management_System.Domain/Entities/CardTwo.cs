using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class CardTwo
{
    public long CardId { get; set; }

    public string? CardNumber { get; set; }

    public string? CardType { get; set; }

    public string? BankName { get; set; }

    public string? CardHolderName { get; set; }

    public string? Amount { get; set; }

    public string? InvoiceNo { get; set; }

    public string? Type { get; set; }
}
