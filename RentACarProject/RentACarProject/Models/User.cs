using Microsoft.AspNetCore.Identity;

namespace RentACarProject.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public enum Roles
    {
        Admin,
        Customer
    }
}
