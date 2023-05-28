using bmarketo.Contexts;
using bmarketo.Repos;
using bmarketo.Services;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bmarketo.Controllers;

public class HomeController : Controller
{

    private readonly ProductService _productService;
    private readonly DataContext _context;
    private readonly ProductRepository _repository;

    public HomeController(DataContext context, ProductService productService, ProductRepository repository)
    {
        _context = context;
        _productService = productService;
        _repository = repository;
    }


    // fixa det under detta imorn 
    public async Task <IActionResult> Index()
    {
        var viewModel = new HomeIndexViewModel
        {

       

            BestCollection = new GridCollectionViewModel
            {
                Title = "Best Collection",
                BreadCrumbs = new List<string> { "All", "Bag", "Dress", "Decoration", "Essentials", "Interior", "Laptops" },
                GridItems = await _productService.GetNewProducts()


            },


                PercentageOff = new GridCollectionViewModel
            {
                Title = "Percentage Off", 
                GridItems = await _productService.GetFeaturedProducts()
            },
   

            TopSelling = new GridCollectionViewModel
            {
                Title = "Top Selling", 
                GridItems = await _productService.GetPopularProducts()
            },

            EndBoxes = new GridCollectionViewModel
            {
             
                GridItems = await _productService.GetEndProducts()
            }

        };
    


        return View(viewModel);
    }
}
