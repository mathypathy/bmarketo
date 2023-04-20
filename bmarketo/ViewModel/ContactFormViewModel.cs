using bmarketo.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace bmarketo.ViewModel
{
    public class ContactFormViewModel
    {
        [RegularExpression(@"^[A-Za-z]+(?:[ \'-][A-Za-z]+)*$", ErrorMessage = "Your Name is not valid. Try again.")]
        public string FullName { get; set; } = null!;
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your Email is not valid. Try again.")]
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Company { get; set; }

        public string Comment { get; set; } = null!;

        public static implicit operator ContactFormEntity(ContactFormViewModel contactFormViewModel)
        {
            return new ContactFormEntity
            {
                FullName = contactFormViewModel.FullName,
                Email = contactFormViewModel.Email,
                PhoneNumber = contactFormViewModel.PhoneNumber,
                Company = contactFormViewModel.Company,
                Comment = contactFormViewModel.Comment,

            };

        }



    }


}
