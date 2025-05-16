using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate.Controllers;

public class FormLayoutsController : Controller
{
public IActionResult Horizontal() => View();
public IActionResult Vertical() => View();
}
