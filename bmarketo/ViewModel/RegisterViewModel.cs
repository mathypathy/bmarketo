using bmarketo.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace bmarketo.ViewModel;

public class RegisterViewModel
{
    [RegularExpression(@"^[A-Za-z]+(?:[ \'-][A-Za-z]+)*$", ErrorMessage ="Your Name is not valid. Try again.")]
    public string FirstName { get; set; } = null!;
    [RegularExpression(@"^[A-Za-z]+(?:[ \'-][A-Za-z]+)*$", ErrorMessage = "Your Last Name is not valid. Try again.")]
    public string LastName { get; set; } = null!;
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your Email is not valid. Try again.")]
    public string Email { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public string PostalCode{ get; set; } = null!;
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()])(?=.*[^\s]).{8,}$", ErrorMessage = "Your Password is not valid. Try again.")]
    public string Password { get; set; } = null!;
    [DataType(DataType.Password)]
    [Compare(nameof(Password),ErrorMessage = "The Password does not match. Try again.")]
    public string ConfirmPassword { get; set; } = null!;

    
    public static implicit operator UserEntity(RegisterViewModel registerViewModel)
    {
        var userEntity = new UserEntity { Email = registerViewModel.Email };
        userEntity.GenerateSecurePassword(registerViewModel.Password);
        return userEntity;
    }
    public static implicit operator ProfileEntity(RegisterViewModel registerViewModel)
    {
        return new ProfileEntity
        {
            FirstName = registerViewModel.FirstName,
            LastName = registerViewModel.LastName,
            StreetName = registerViewModel.StreetName,
            PostalCode = registerViewModel.PostalCode,
            City = registerViewModel.City,
            Country = registerViewModel.Country,

        };
       
    }

}
