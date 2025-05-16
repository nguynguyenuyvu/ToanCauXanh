using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class SlideShow
{
    public int SildeId { get; set; }

    public string SlideName { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string? Url { get; set; }

    public string? Target { get; set; }

    public string Language { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
