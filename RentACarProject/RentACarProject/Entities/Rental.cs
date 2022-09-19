using System;

namespace RentACarProject.Entities
{
    public class Rental:BaseEntity
    {
        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        #region CarRentalRelation
        public int CarId { get; set; }
        public Car Car { get; set; }
        #endregion

        #region UserRentalRelation
        public string UserId { get; set; }
        public User User { get; set; }
        #endregion
    }
}
