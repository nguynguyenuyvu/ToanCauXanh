using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class Course
{
    public int CourseId { get; set; }

    public string Title { get; set; } = null!;

    public string? Url { get; set; }

    public string Decription { get; set; } = null!;

    public string? Contents { get; set; }

    public string? Keywords { get; set; }

    public string? Tags { get; set; }

    public string? Image { get; set; }

    public string? ThumbImage { get; set; }

    public string Language { get; set; } = null!;

    public bool IsActive { get; set; }

    public string Author { get; set; } = null!;

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    /// <summary>
    /// Khóa học có tiền hay hiện nút tùy tâm
    /// </summary>
    public bool IsPrice { get; set; }

    public double? Price { get; set; }

    /// <summary>
    /// Hiển thị giá ảo
    /// </summary>
    public double? PricePromotion { get; set; }

    public int CategoryCourseId { get; set; }

    public virtual CategoryCourse CategoryCourse { get; set; } = null!;

    public virtual ICollection<CourseDetail> CourseDetails { get; set; } = new List<CourseDetail>();
}
