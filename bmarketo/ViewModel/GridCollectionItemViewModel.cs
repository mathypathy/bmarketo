using bmarketo.Models.Entities;

namespace bmarketo.ViewModel
{
    public class GridCollectionItemViewModel
    {
        public string Id { get; set; } = null!;
        public string ProductImage { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public decimal? OldPrice { get; set; }
     
        public string ArticleNumber { get; set; } = null!;
        

        // ta bort denna under om ej fungerar

        public IEnumerable<ProductRegistrationViewModel> Products { get; set; } = new HashSet<ProductRegistrationViewModel>();


        public static implicit operator GridCollectionItemViewModel(ProductEntity productmodel)
        {
            var item = new GridCollectionItemViewModel
            {
                Id = productmodel.ArticleNumber.ToString(),
                Name = productmodel.Name,
                Price = (decimal)productmodel.Price,
                ProductImage = productmodel.ProductImage,
                Description = productmodel.Description,
           

            }; return item;
        }

        



    }



}
