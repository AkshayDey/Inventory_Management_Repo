using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class UserModule
{
    public long UserModuleId { get; set; }

    public long UserId { get; set; }

    public long ModuleId { get; set; }

    public bool AddPermission { get; set; }

    public bool ViewPermission { get; set; }
}
