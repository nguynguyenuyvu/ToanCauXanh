using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class CourseDetail
{
    public int CourseDetailId { get; set; }

    public int CourseId { get; set; }

    public string? Fullname { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public DateTime DateRegister { get; set; }

    public double? Price { get; set; }

    public virtual Course Course { get; set; } = null!;
}
