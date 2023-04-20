using bmarketo.Services;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace bmarketo.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserService _userService;

        public RegisterController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Register()
        {
            ViewData["Title"] = "Register";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _userService.UserExist(x => x.Email == registerViewModel.Email))
                {
                    ModelState.AddModelError("", "There is already an account with that Email. Try Again.");

                }
                else
                {
                    if (await _userService.RegisterAsync(registerViewModel))
                    {
                        return RedirectToAction("Register", "Login");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Something went wrong when creating the user. Try Again.");
                    }
                   
                }
             
            }

            ViewData["Title"] = "Register";
            return View(registerViewModel);


            
             
            
           
        }




        // LOGIN


        public IActionResult Login()
        {
            ViewData["Title"] = "Login";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                if(await _userService.LoginAsync(loginViewModel)){
                    return RedirectToAction("Account", "Account");

                }
                ModelState.AddModelError("", "That Email does not exist. Please Try again.");
            }
            

            return View(loginViewModel);


        }
    }
}
