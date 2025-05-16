namespace ToanCauXanh.Models
{
    public class BreadcrumbModel
    {
        public BreadcrumbUrl UrlMain { get; set; }

        public List<BreadcrumbUrl> Urls { get; set; }
    }

    public class BreadcrumbUrl
    { 
        public string Url { get; set; }
        public string Title { get; set; }
    }
}
