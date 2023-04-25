using bmarketo.Contexts.Identity;
using Microsoft.EntityFrameworkCore;

namespace bmarketo.Models.Entities
{
    [PrimaryKey(nameof(UserId),nameof(AddressID))]
    public class UserAdressEntity
    {
        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;
        public int AddressID { get; set; } 
        public AdressEntity Address { get; set; } = null!;
    }
}
