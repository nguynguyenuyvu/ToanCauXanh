using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class News
{
    public int NewsId { get; set; }

    public string Title { get; set; } = null!;

    public string? Url { get; set; }

    public string Decription { get; set; } = null!;

    public string Contents { get; set; } = null!;

    public string? Keywords { get; set; }

    public string? Tags { get; set; }

    public string? Image { get; set; }

    public string? ThumbImage { get; set; }

    public string? Language { get; set; }

    public bool IsActive { get; set; }

    public string Author { get; set; } = null!;

    public DateTime PublicDate { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int CategoryNewsId { get; set; }

    public virtual CategoryNews CategoryNews { get; set; } = null!;
}
