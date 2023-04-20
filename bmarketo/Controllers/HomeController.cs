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
                BreadCrumbs = new List<string> { "All","Bag","Dress","Decoration","Essentials","Watches"},
                GridItems = new List<GridCollectionItemViewModel>
                {
                    new GridCollectionItemViewModel{Id = "1", Title="Apple Watch Collection", Price=30, ImageUrl="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel{Id = "2", Title="Apple Watch Collection", Price=40, ImageUrl="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel{Id = "3", Title="Apple Watch Collection", Price=50, ImageUrl="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel{Id = "4", Title="Apple Watch Collection", Price=60, ImageUrl="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel{Id = "5", Title="Apple Watch Collection", Price=70, ImageUrl="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel{Id = "6", Title="Apple Watch Collection", Price=80, ImageUrl="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel{Id = "7", Title="Apple Watch Collection", Price=90, ImageUrl="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel{Id = "8", Title="Apple Watch Collection", Price=100, ImageUrl="/Images/Placeholders/270x295.svg" }
                }
                
            }
    };
    


        return View(viewModel);
    }
}
