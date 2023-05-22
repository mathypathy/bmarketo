using bmarketo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bmarketo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {


        // Prova detta imorn, hämta även datacontext, glöm ej. 
        //var viewModel = new HomeIndexViewModel
        //{
        //    BestCollection = new GridCollectionViewModel
        //    {
        //        Title = "Best Collection",
        //        BreadCrumbs = new List<string> { "All", "Bag", "Dress", "Decoration", "Essentials", "Watches" },
        //        GridItems = _dbContext.Products.Select(p => new GridCollectionItemViewModel
        //        {
        //            Id = p.Id.ToString(),
        //            Name = p.Name,
        //            Price = p.Price,
        //            ProductImage = p.ImageUrl
        //        }).ToList()
        //    },





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

            PercentageOff = new GridCollectionViewModel
            {
                Title = "Percentage Off", 
                GridItems = new List <GridCollectionItemViewModel>
                {
                    new GridCollectionItemViewModel {Id = "9", Name = "Apple Watch Collection", OldPrice = 130, Price = 110, ProductImage = "/Images/Placeholders/369x310"},
                   
                }
            },
            PercentageOff2 = new GridCollectionViewModel
            {
                Title = "Percentage Off",
                GridItems = new List<GridCollectionItemViewModel>
                {
                    new GridCollectionItemViewModel {Id = "10", Name = "Apple Watch Collection", OldPrice = 130, Price = 110, ProductImage = "/Images/Placeholders/369x310"},

                }
            },

            TopSelling = new GridCollectionViewModel
            {
                Title = "Top Selling", 
                GridItems = new List <GridCollectionItemViewModel>
                { 
                    new GridCollectionItemViewModel {Id = "11", Name="Apple Watch Collection", OldPrice = 120, Price = 80, ProductImage ="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel {Id = "12", Name="Apple Watch Collection", OldPrice = 120, Price = 80, ProductImage ="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel {Id = "13", Name="Apple Watch Collection", OldPrice = 120, Price = 80, ProductImage ="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel {Id = "14", Name="Apple Watch Collection", OldPrice = 120, Price = 80, ProductImage ="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel {Id = "15", Name="Apple Watch Collection", OldPrice = 120, Price = 80, ProductImage ="/Images/Placeholders/270x295.svg"},
                    new GridCollectionItemViewModel {Id = "16", Name="Apple Watch Collection", OldPrice = 120, Price = 80, ProductImage ="/Images/Placeholders/270x295.svg"}
                }
            },

            EndBoxes = new GridCollectionViewModel
            {
                Title ="End boxes", 
                GridItems = new List <GridCollectionItemViewModel>
                {
                    new GridCollectionItemViewModel {Id = "17", Name="Apple Watch Collection", Price = 80, ProductImage="/Images/Placeholders/370x295.svg"},
                    new GridCollectionItemViewModel {Id = "18", Name="Apple Watch Collection", Price = 80, ProductImage="/Images/Placeholders/370x295.svg"},
                    new GridCollectionItemViewModel {Id = "19", Name="Apple Watch Collection", Price = 80, ProductImage="/Images/Placeholders/370x295.svg"}
                }
            }

        };
    


        return View(viewModel);
    }
}
