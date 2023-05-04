using bmarketo.Contexts.Identity;
using bmarketo.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace bmarketo.ViewModel
{
    public class UserRegisterViewModel
    {
        [Display(Name = "First Name:")]
        [RegularExpression(@"^[A-Za-z]+(?:\s[A-Za-z]+)?$")]
        [Required(ErrorMessage = "You must provide a first name.")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name:")]
        [RegularExpression(@"^[A-Za-z]+(?:\s[A-Za-z]+)?$", ErrorMessage = "Test")]
        [Required(ErrorMessage = "You must provide a last name.")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Street Name:")]
        [Required(ErrorMessage = "You must provide a street name.")]
        public string StreetName { get; set; } = null!;

        [Display(Name = "Postal Code:")]
        [Required(ErrorMessage = "You must provide your postal code.")]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City:")]
        [Required(ErrorMessage = "You must provide your city name.")]
        public string City { get; set; } = null!;

        [Display(Name = "Phone number:")]
        public string? Mobile { get; set; }

        [Display(Name = "Company:")]
        public string? Company { get; set; }


        [Display(Name = "Email:")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must provide a email-address.")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password:")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[a-zA-Z\d!@#$%^&*]{8,}$")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must provide a password.")]
        public string Password { get; set; } = null!;


        [Display(Name = "Confirm Password:")]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must confirm your password.")]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "Profile image:")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        [Display(Name = "I Have read and accepted the terms and agreements:")]
        [Required(ErrorMessage = "You must accept the terms and agreements.")]
        public bool TermsAndAgreement { get; set; } = false;

        public static implicit operator AppUser(UserRegisterViewModel viewModel)
        {
            return new AppUser
            {
                UserName = viewModel.Email,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                PhoneNumber = viewModel.Mobile,
                Company = viewModel.Company
            };
        }
        public static implicit operator AdressEntity(UserRegisterViewModel viewModel)
        {
            return new AdressEntity
            {
                StreetName = viewModel.StreetName,
                City = viewModel.City,
                PostalCode = viewModel.PostalCode,



            };
        }
            




    }
}
