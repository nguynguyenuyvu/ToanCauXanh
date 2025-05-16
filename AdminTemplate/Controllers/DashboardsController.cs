using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate.Controllers
{
    public class DashboardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
