using bmarketo.Contexts;
using bmarketo.Models.Entities;

namespace bmarketo.Repos
{
    public class AddressRepository : Repository<AdressEntity>
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }
    }
}
