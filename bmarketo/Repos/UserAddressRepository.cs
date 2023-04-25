using bmarketo.Contexts;
using bmarketo.Models.Entities;

namespace bmarketo.Repos
{
    public class UserAddressRepository : Repository<UserAdressEntity>
    {
        public UserAddressRepository(DataContext context) : base(context)
        {
        }
    }
}
