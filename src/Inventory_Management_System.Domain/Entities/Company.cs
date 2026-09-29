using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class Company
{
    public long CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactPersonPhone { get; set; }

    public string? ContactPersonName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public decimal? Vat { get; set; }

    public string? TradeLicence { get; set; }

    public string? Tiin { get; set; }

    public string? CompanyLogo { get; set; }

    public string? CompanyAddress { get; set; }
}
