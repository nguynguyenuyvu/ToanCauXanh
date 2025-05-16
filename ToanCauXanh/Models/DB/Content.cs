using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class Content
{
    public int ContentId { get; set; }

    public string ContentCode { get; set; } = null!;

    public string ContentName { get; set; } = null!;

    public string? ContentDetail { get; set; }

    public string Language { get; set; } = null!;

    public string? Title { get; set; }

    public string? Keyword { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool IsActive { get; set; }
}
