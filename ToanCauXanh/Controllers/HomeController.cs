using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToanCauXanh.Models;
using ToanCauXanh.Core;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ToanCauXanh.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly LanguageHelper _langHelper;

    public HomeController(ILogger<HomeController> logger, LanguageHelper langHelper)
    {
        _logger = logger;
        _langHelper = langHelper;
    }

    //Trang chủ
    public IActionResult Index()
    {
        return View();
    }

    [Route("gioi-thieu.html")]
    public IActionResult About()
    {
        string lang = _langHelper.GetCurrentLanguage();

        BreadcrumbModel breadcrumbModel = new BreadcrumbModel();
        BreadcrumbUrl urlMain = new BreadcrumbUrl();
        urlMain.Title = Resources.GetLanguageJSON("AboutUs-" + lang);
        urlMain.Url = "/gioi-thieu.html";

        List<BreadcrumbUrl> urls = new List<BreadcrumbUrl>();
        {
            BreadcrumbUrl url = new BreadcrumbUrl();
            url.Url = "/";
            url.Title = Resources.GetLanguageJSON("HomePage-" + lang);

            urls.Add(url);
        }
        breadcrumbModel.UrlMain = urlMain;
        breadcrumbModel.Urls = urls;

        return View(breadcrumbModel);
    }

    [Route("lien-he.html")]
    public IActionResult Contact()
    {
        string lang = _langHelper.GetCurrentLanguage();

        BreadcrumbModel breadcrumbModel = new BreadcrumbModel();
        BreadcrumbUrl urlMain = new BreadcrumbUrl();
        urlMain.Title = Resources.GetLanguageJSON("Contact-" + lang);
        urlMain.Url = "/lien-he.html";

        List<BreadcrumbUrl> urls = new List<BreadcrumbUrl>();
        {
            BreadcrumbUrl url = new BreadcrumbUrl();
            url.Url = "/";
            url.Title = Resources.GetLanguageJSON("HomePage-" + lang);

            urls.Add(url);
        }
        breadcrumbModel.UrlMain = urlMain;
        breadcrumbModel.Urls = urls;

        return View(breadcrumbModel);
    }

    [HttpPost("/lang/set")]
    public IActionResult SetLanguage(string lang, string returnUrl = "/")
    {
        // Gán cookie có thời hạn 30 ngày
        Response.Cookies.Append("lang", lang, new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddDays(30),
            IsEssential = true
        });

        return LocalRedirect(returnUrl);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
