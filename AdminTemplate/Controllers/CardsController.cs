using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate.Controllers;

public class CardsController : Controller
{
  public IActionResult Basic() => View();
}
