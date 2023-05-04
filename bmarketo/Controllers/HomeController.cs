using bmarketo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel
        {
            BestCollection = new GridCollectionViewModel
            {
                Title = "Best Collection",
                BreadCrumbs = new List<string> { "All", "Bag", "Dress", "Decoration", "Essentials", "Watches" },
                GridItems = new List<GridCollectionItemViewModel>
                {
                    new GridCollectionItemViewModel { Id = "1", Name = "Apple Watch Collection", Price = 30, ProductImage = "/Images/Placeholders/270x295.svg" },
                    new GridCollectionItemViewModel { Id = "2", Name = "Apple Watch Collection", Price = 40, ProductImage = "/Images/Placeholders/270x295.svg" },
                    new GridCollectionItemViewModel { Id = "3", Name = "Apple Watch Collection", Price = 50, ProductImage = "/Images/Placeholders/270x295.svg" },
                    new GridCollectionItemViewModel { Id = "4", Name = "Apple Watch Collection", Price = 60, ProductImage = "/Images/Placeholders/270x295.svg" },
                    new GridCollectionItemViewModel { Id = "5", Name = "Apple Watch Collection", Price = 70, ProductImage = "/Images/Placeholders/270x295.svg" },
                    new GridCollectionItemViewModel { Id = "6", Name = "Apple Watch Collection", Price = 80, ProductImage = "/Images/Placeholders/270x295.svg" },
                    new GridCollectionItemViewModel { Id = "7", Name = "Apple Watch Collection", Price = 90, ProductImage = "/Images/Placeholders/270x295.svg" },
                    new GridCollectionItemViewModel { Id = "8", Name = "Apple Watch Collection", Price = 100, ProductImage = "/Images/Placeholders/270x295.svg" }
                }

            },

         

        };
    


        return View(viewModel);
    }
}
