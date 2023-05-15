using bmarketo.Contexts;
using bmarketo.Contexts.Identity;
using bmarketo.Models.Entities;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace bmarketo.Controllers
{
    // I didnt get the authorize to work properly so if you
    // Remove authorize you can see the backoffice functions.
    // If you dont remove it you'll get "Access Denied". 
    // You will find the functions at /admin in the browser.
    // 05/05/23, Added a claim that got it to work.
    // still gonna leave this here if future problems would happen.

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly UserManager<AppUser> _userManager;

        public AdminController(DataContext dataContext, UserManager<AppUser> userManager)
        {
            _dataContext = dataContext;
            _userManager = userManager;

        }

        [Authorize]
        public IActionResult Index()
        {

            return View();
        }



        [Authorize]
        public async Task<IActionResult> OutputUserInfo()
        {
            var users = await _userManager.Users.ToListAsync();
            var usersView = users.Select(u => new SecureUserOutputViewModel
            {

                FirstName = u.FirstName,
                LastName = u.LastName,
                Roles = string.Join(", ", _userManager.GetRolesAsync(u).Result)
            }).ToList();

            return View(usersView);
        }

        
    }
}
