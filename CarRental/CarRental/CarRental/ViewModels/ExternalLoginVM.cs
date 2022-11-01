using System.ComponentModel.DataAnnotations;

namespace CarRental.ViewModels
{
    public class ExternalLoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
