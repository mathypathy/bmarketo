using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "ProductDetail";
            return View();
        }
    }
}
