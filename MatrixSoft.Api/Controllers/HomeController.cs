using Microsoft.AspNetCore.Mvc;

namespace MatrixSoft.Api.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Calendar");
    }

    public IActionResult Calendar()
    {
        return View();
    }
}

