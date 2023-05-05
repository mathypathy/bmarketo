using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers
{
    // I didnt get the authorize to work properly so if you
    // Remove authorize you can see the backoffice functions.
    // If you dont remove it you'll get "Access Denied". 
    // You will find the functions at /admin in the browser.
    // 05/05/23, Added a claim that got it to work.
    // still gonna leave this here if future problems would happen.

    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
