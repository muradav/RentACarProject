using System.ComponentModel.DataAnnotations;

namespace CarRental.ViewModels
{
    public class ForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
