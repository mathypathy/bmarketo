using bmarketo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace bmarketo.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<ProfileEntity> Profiles { get; set; }

    public DbSet<ContactFormEntity> Contacts { get; set; }

    public DbSet<ProductEntity> Products { get; set; } 
}
