using bmarketo.Contexts;
using bmarketo.Models.Entities;
using bmarketo.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bmarketo.Services;

public class UserService
{

    private readonly DataContext _context; 
    public UserService(DataContext context)
    {
        _context = context;
    }

   
    public async Task<bool>UserExist(Expression<Func<UserEntity,bool>>predicate)
    {
        if (await _context.TheUsers.AnyAsync(predicate))
            return true;

        return false;
    }
    public async Task<UserEntity> GetAsync(Expression<Func<UserEntity, bool>> predicate)
    {
      var userEntity = await _context.TheUsers.FirstOrDefaultAsync(predicate);
        return userEntity!;
    }
    public async Task<bool> RegisterAsync(RegisterViewModel registerViewModel)
    {
        try
        {
                // convert to userEntity and ProfileEntity from registrationform
                UserEntity userEntity = registerViewModel;
                ProfileEntity profileEntity = registerViewModel;

                // create user
                _context.TheUsers.Add(userEntity);
                await _context.SaveChangesAsync();

                //Create user profile
                profileEntity.UserId = userEntity.Id;
                _context.Profiles.Add(profileEntity);
                await _context.SaveChangesAsync();

                return true;
        }
        catch
        {
            return false;
          
        }
    }

    public async Task<bool>LoginAsync(LoginViewModel loginViewModel)
    {
        var userEntity = await GetAsync(x => x.Email == loginViewModel.Email);
        if(userEntity != null)
        {
            return userEntity.VerifySecuredPassword(loginViewModel.Password);
        }
        return false;
    }

}
