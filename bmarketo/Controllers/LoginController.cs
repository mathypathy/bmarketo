using bmarketo.Contexts;
using bmarketo.Models.Entities;
using bmarketo.Services;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace bmarketo.Controllers
{
   
    public class LoginController : Controller
    {

        private readonly AuthenticationService _auth;

        public LoginController(AuthenticationService auth)
        {
            _auth = auth;
     
        }

        public IActionResult Index(string ReturnUrl = null!)
        {
            var viewModel = new UserLoginViewModel();
            if(ReturnUrl != null)
                viewModel.ReturnUrl = ReturnUrl;
    
            return View(viewModel);
        }

        //FIXA DETTA IMORN 

        [HttpPost]
        public async Task <IActionResult> Index(UserLoginViewModel viewModel)
        {
            if(ModelState.IsValid)
            {


                if (await _auth.LoginAsync(viewModel))
              
                    return LocalRedirect(viewModel.ReturnUrl);

                ModelState.AddModelError("", "Incorrect email or password.");
            }
            
            return View(viewModel);
        }

      


    }
}
