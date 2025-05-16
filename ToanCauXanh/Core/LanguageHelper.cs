namespace ToanCauXanh.Core
{
    public class LanguageHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _defaultLanguage = "vi";

        public LanguageHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCurrentLanguage()
        {
            var context = _httpContextAccessor.HttpContext;
            if (context == null)
                return _defaultLanguage;

            // Ưu tiên cookie
            if (context.Request.Cookies.TryGetValue("lang", out var cookieLang))
            {
                return cookieLang;
            }

            // Sau đó là header Accept-Language
            var acceptLang = context.Request.Headers["Accept-Language"].ToString();
            if (!string.IsNullOrEmpty(acceptLang))
            {
                var langPart = acceptLang.Split(',')[0].Split('-')[0].Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(langPart))
                {
                    return langPart;
                }
            }

            return _defaultLanguage;
        }
    }
}
