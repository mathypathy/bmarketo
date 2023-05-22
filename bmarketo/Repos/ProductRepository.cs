using bmarketo.Contexts;
using bmarketo.Models.Entities;

namespace bmarketo.Repos
{
    public class ProductRepository : Repository<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
