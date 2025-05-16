using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class Contact
{
    public int ContactId { get; set; }

    public string Fullname { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telephone { get; set; }

    public string? Project { get; set; }

    public string? Title { get; set; }

    public string? Message { get; set; }

    public DateTime CreateDate { get; set; }

    public int Status { get; set; }
}
