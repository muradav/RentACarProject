using Microsoft.AspNetCore.Identity;

namespace RentACarProject.Entities
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        #region UserRentalRelation
        public int RentalId { get; set; }
        public Rental Rental { get; set; }
        #endregion
    }

    public enum Roles
    {
        Admin,
        Customer
    }
}
