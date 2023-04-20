using System.ComponentModel.DataAnnotations;

namespace bmarketo.ViewModel;

public class LoginViewModel
{
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
}
