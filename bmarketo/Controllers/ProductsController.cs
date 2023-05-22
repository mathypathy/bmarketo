using bmarketo.Contexts;
using bmarketo.Models;
using bmarketo.Services;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers;




public class ProductsController : Controller
{
  
    private readonly ProductService _productService;
 
    public ProductsController(ProductService productService)
    {
        _productService = productService;
       
    }




    public  IActionResult Index()
    {
        ViewData["Title"] = "Products";
        
        return View();
    }


    [Authorize(Roles ="admin")]
    public async Task<IActionResult> RegisterProduct()
    {
        var viewmodel = new ProductRegistrationViewModel
        {
            Products = await _productService.GetAllAsync()
        };
        return View(viewmodel);
    }


 //FIXA HÄR UNDER

    [Authorize(Roles = "admin")]
    [HttpPost]
    public async Task<IActionResult> RegisterProduct(ProductRegistrationViewModel productRegistrationViewModel)
    {
        if (ModelState.IsValid)
        {
           var product = await _productService.CreateAsyncTwo(productRegistrationViewModel);
            if(product != null)
            {
                if(productRegistrationViewModel.ProductImage != null)
                    await _productService.UploadImageAsync(product, productRegistrationViewModel.ProductImage);
                return RedirectToAction("Index", "Admin");
            }
            ModelState.AddModelError("", "Something went wrong when making the product.");
        }


        return View();
    }





    public IActionResult Search()
    {
        ViewData["Title"] = "Search for products";
        return View();
    }

}
