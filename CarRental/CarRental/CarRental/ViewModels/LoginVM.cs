using System.ComponentModel.DataAnnotations;

namespace CarRental.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Düzgün elektron adres daxil edin"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Düzgün şifrə daxil edin"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
