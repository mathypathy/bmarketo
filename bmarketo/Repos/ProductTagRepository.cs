using bmarketo.Contexts;
using bmarketo.Models.Entities;

namespace bmarketo.Repos
{
    public class ProductTagRepository : Repository<ProductTagEntity>
    {
        public ProductTagRepository(DataContext context) : base(context)
        {
        }
    }
}
