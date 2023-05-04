using bmarketo.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bmarketo.Models.Entities;
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
