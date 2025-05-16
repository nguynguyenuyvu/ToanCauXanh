using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate.Controllers;

public class FormsController : Controller
{
  public IActionResult BasicInputs() => View();
  public IActionResult InputGroups() => View();
}
