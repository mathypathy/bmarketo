using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            return View();
        }
    }
}
