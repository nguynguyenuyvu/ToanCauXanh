using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class Role
{
    public int RoleId { get; set; }

    public string? RoleValue { get; set; }

    public string? RoleName { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
