using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
