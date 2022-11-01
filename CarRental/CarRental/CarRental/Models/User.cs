using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ImageUrl { get; set; }
        [NotMappedAttribute]
        public IFormFile Image { get; set; }
    }

    public enum Roles
    {
        Admin,
        Customer
    }
}
