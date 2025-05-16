using ToanCauXanh.Models.DB;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ToanCauXanh.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        ToanCauXanhContext db = new ToanCauXanhContext();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }

            //Check the user name and password
            //Here can be implemented checking logic from the database
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            Account account = db.Accounts.Where(m => m.Username == userName && m.Password == password).FirstOrDefault();

            if (account.AccountId > 0)
            {
                Role role = db.Roles.Where(m => m.RoleId == account.RoleId).FirstOrDefault();

                //Create the identity for the user
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, role.RoleValue)
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Dashboards");
            }

            ViewBag.Info = "Sai tên đăng nhập hoặc mật khẩu";
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        
    }
}
