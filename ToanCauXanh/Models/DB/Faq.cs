using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class Faq
{
    public int FaqId { get; set; }

    public string Question { get; set; } = null!;

    public string Answer { get; set; } = null!;

    public string Language { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }
}
