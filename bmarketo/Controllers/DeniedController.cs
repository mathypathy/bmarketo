using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers
{
    public class DeniedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
