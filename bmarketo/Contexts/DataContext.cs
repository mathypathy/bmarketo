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
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<ProductTagEntity> ProductTag { get; set; }
    public DbSet<AdressEntity> AspNetAdresses { get; set; }
    public DbSet<UserAdressEntity>AspNetUsersAddresses { get; set; }

















    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //    base.OnModelCreating(builder);
    //    var roleId = Guid.NewGuid().ToString();
    //    var userId = Guid.NewGuid().ToString();



    //    builder.Entity<IdentityRole>().HasData(
    //        new IdentityRole {
    //            Id = roleId,
    //            Name = "SystemAdministrator",
    //            NormalizedName = "SYSTEMADMINISTRATOR"

    //            }
    //        );

    //    var passwordHasher = new PasswordHasher<AppUser>();

    //    builder.Entity<AppUser>().HasData(new AppUser
    //    {
    //        Id = userId,
    //        FirstName = " ",
    //        LastName =" ",
    //        UserName = "administrator@domain.com",
    //        Email = "administrator@domain.com",
    //        PasswordHash = passwordHasher.HashPassword(null!, "BytMig123!")

    //    });

    //    builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
    //    {
    //        RoleId = roleId,
    //        UserId = userId
    //    });


    //}
}
