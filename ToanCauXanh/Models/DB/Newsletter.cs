using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class Newsletter
{
    public int NewsLetterId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
