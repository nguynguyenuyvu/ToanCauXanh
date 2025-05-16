using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToanCauXanh.Core
{
    public static class HtmlHelperExtensions
    {
        public static string IsActive(this IHtmlHelper htmlHelper, string path)
        {
            var current = htmlHelper.ViewContext.HttpContext.Request.Path.Value?.ToLower();
            return current == path.ToLower() ? "active" : "";
        }
    }
}
