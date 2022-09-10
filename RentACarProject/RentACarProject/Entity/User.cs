using Microsoft.AspNetCore.Identity;

namespace RentACarProject.Entity
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
