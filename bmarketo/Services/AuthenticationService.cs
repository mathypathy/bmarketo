using bmarketo.Contexts.Identity;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bmarketo.Services
{
    public class AuthenticationService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AddressService _addressService;
        private readonly SignInManager<AppUser> _SignInManager;

        public AuthenticationService(UserManager<AppUser> userManager, AddressService addressService, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _addressService = addressService;
            _SignInManager = signInManager;
        }

        public async Task<bool> UserAlreadyExistsAsync(Expression<Func<AppUser,bool>> expression)
        {
            return await _userManager.Users.AnyAsync(expression);
        }

        public async Task<bool> RegisterUserAsync(UserRegisterViewModel viewModel)
        {
            AppUser appUser = viewModel;
            var result = await _userManager.CreateAsync(appUser, viewModel.Password);
            if (result.Succeeded)
            {
                var adressEntity = await _addressService.GetOrCreateAsync(viewModel);
                if (adressEntity != null)
                {
                    await _addressService.AddAddressAsync(appUser,adressEntity);
                    return true;
                }
            }
            return false;
        }


        public async Task<bool> LoginUserAsync(UserRegisterViewModel viewModel)
        {
            AppUser appUser = viewModel;
            var result = await _userManager.CreateAsync(appUser, viewModel.Password);
            if (result.Succeeded)
            {
                var adressEntity = await _addressService.GetOrCreateAsync(viewModel);
                if (adressEntity != null)
                {
                    await _addressService.AddAddressAsync(appUser, adressEntity);
                    return true;
                }
            }
            return false;
        }



        public async Task <bool>LoginAsync(UserLoginViewModel viewModel)
        {
            var appUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email);
            if(appUser != null)
            {
                var result = await _SignInManager.PasswordSignInAsync(appUser, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;
            }
            return false;
        }







    }
}
