using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class CategoryCourse
{
    public int CategoryCourseId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string CategoryCode { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Decription { get; set; }

    public string? Keywords { get; set; }

    public string? Image { get; set; }

    public string? ThumbImage { get; set; }

    public string Language { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
