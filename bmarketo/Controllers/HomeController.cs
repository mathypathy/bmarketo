using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
       ViewData["Title"] = "Home";
       return View();
    }
}
