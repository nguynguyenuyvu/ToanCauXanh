using System;
using System.Collections.Generic;

namespace ToanCauXanh.Models.DB;

public partial class ClientsSay
{
    public int ClientSayId { get; set; }

    public string? Fullname { get; set; }

    public string? Image { get; set; }

    /// <summary>
    /// Chức vụ
    /// </summary>
    public string? Position { get; set; }

    public string? Contents { get; set; }

    /// <summary>
    /// HÌnh ảnh khách hàng đánh giá
    /// </summary>
    public string? ContentImage { get; set; }

    public double? Rate { get; set; }

    public string? Language { get; set; }
}
