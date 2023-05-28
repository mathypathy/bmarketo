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
    private readonly TagService _tagService; 
    public ProductsController(ProductService productService, TagService tagService)
    {
        _productService = productService;
        _tagService = tagService;
    }




    public async Task <IActionResult> Index()
    {
        ViewData["Title"] = "Index";
        var viewmodel = new ProductRegistrationViewModel
        {
            Products = await _productService.GetAllAsync()
        };
        return View(viewmodel);
    }


    [Authorize(Roles ="admin")]
    public async Task<IActionResult> RegisterProduct()
    {
        ViewBag.Tags = await _tagService.GetTagsAsync();
        var viewmodel = new ProductRegistrationViewModel
        {
            Products = await _productService.GetAllAsync()
        };
        return View(viewmodel);
    }


 //FIXA HÄR UNDER IMORN

    [Authorize(Roles = "admin")]
    [HttpPost]
    public async Task<IActionResult> RegisterProduct(ProductRegistrationViewModel productRegistrationViewModel, string[] tags )
    {
        if (ModelState.IsValid)
        {

            //if (await _productService.CreateAsync(productRegistrationViewModel))
            //    await _productService.AddProductTagsAsync(productRegistrationViewModel, tags);


            // Fungerande kod:
            var product = await _productService.CreateAsyncTwo(productRegistrationViewModel);
            if(product != null)
            {
                await _productService.AddProductTagsAsync(productRegistrationViewModel, tags); // ta bort denna om ej går. 
                if (productRegistrationViewModel.ProductImage != null)
                    await _productService.UploadImageAsync(product, productRegistrationViewModel.ProductImage);
                return RedirectToAction("Index", "Admin");
            }
            ViewBag.Tags = await _tagService.GetTagsAsync(tags);
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
