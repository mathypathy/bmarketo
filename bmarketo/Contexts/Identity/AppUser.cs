using bmarketo.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace bmarketo.Contexts.Identity
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? CompanyName { get; set; } 
        public string? ImageURL { get; set; }
        public ICollection<UserAdressEntity> Addresses { get; set; } = new HashSet<UserAdressEntity>();

    }
}
