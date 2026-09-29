using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class Role
{
    public long RoleId { get; set; }

    public string? RoleName { get; set; }

    public int? Status { get; set; }
}
