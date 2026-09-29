using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Domain.Entities;

public partial class UserInfo
{
    public long UserId { get; set; }

    public string? Name { get; set; }

    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? Type { get; set; }

    public bool? Status { get; set; }

    public long RoleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? RetryAttempt { get; set; }

    public bool? Islocked { get; set; }

    public DateTime? LockedDateTime { get; set; }

    public long? UserPreferredWarehouseId { get; set; }

    public bool? UserPermissionToChangeWarehouse { get; set; }

    public string? UserImage { get; set; }

    public long? WarhouseId { get; set; }
}
