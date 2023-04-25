using bmarketo.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bmarketo.Models.Entities;
namespace bmarketo.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index(int id)
        {
            // FIXA DETTA IMORN
            // Retrieve the product from the database using the ID
            var product = DataContext.Products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                // Store the ID of the product in ViewData
                ViewData["ProductId"] = id;
                // Pass the product to the View
                return View(product);
            }

            



            ViewData["Title"] = "ProductDetail";
            return View();
        }
    }
}
