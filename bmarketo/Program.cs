using bmarketo.Contexts;
using bmarketo.Contexts.Identity;
using bmarketo.Models;
using bmarketo.Repos;
using bmarketo.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));


// add services 
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<ContactFormService>();
builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<UserAddressRepository>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<AuthenticationService>();

builder.Services.AddIdentity<AppUser, IdentityRole>(
    x =>
    {
        x.SignIn.RequireConfirmedAccount = false;
        x.Password.RequiredLength = 8;
        x.User.RequireUniqueEmail = true;
    }).AddEntityFrameworkStores<DataContext>();
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/account";
    x.LogoutPath = "/home";
    x.AccessDeniedPath = "/denied";
});



var app = builder.Build();
app.UseHsts();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
