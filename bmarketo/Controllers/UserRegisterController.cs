using bmarketo.Services;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers
{
    public class UserRegisterController : Controller
    {
        private readonly AuthenticationService _auth;
        public UserRegisterController(AuthenticationService auth)
        {
            _auth = auth;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(UserRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _auth.UserAlreadyExistsAsync(x=> x.Email == viewModel.Email))
                    ModelState.AddModelError("", "A user with that email already exist.");
                

                if(await _auth.RegisterUserAsync(viewModel))
                    return RedirectToAction("index","login");
            }

            return View(viewModel);
        }
    }
}
