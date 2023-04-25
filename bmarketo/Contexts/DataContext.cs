using bmarketo.Contexts.Identity;
using bmarketo.Models;
using bmarketo.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bmarketo.Contexts;

public class DataContext : IdentityDbContext<AppUser>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> TheUsers { get; set; }
    public DbSet<ProfileEntity> Profiles { get; set; }

    public DbSet<ContactFormEntity> Contacts { get; set; }

    public DbSet<ProductEntity> Products { get; set; }

    public DbSet<AdressEntity> AspNetAdresses { get; set; }
    public DbSet<UserAdressEntity>AspNetUsersAddresses { get; set; }

}
