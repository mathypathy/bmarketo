using bmarketo.Models;

namespace bmarketo.ViewModel
{
    public class ProductViewModel
    {
        public IEnumerable<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
