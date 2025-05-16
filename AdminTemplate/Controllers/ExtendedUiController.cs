using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate.Controllers;

public class ExtendedUiController : Controller
{
  public IActionResult PerfectScrollbar() => View();
  public IActionResult TextDivider() => View();
}
