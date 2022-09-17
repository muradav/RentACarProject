using System.Collections.Generic;

namespace RentACarProject.Entities
{
    public class Car:BaseEntity
    {
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string FuelType { get; set; }
        public string TransmissionType { get; set; }
        public int PassengerCount { get; set; }


        #region BrandCarRelation
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        #endregion

        #region CarImageCarRelation
        public List<CarImage> CarImages { get; set; }
        #endregion

        #region CarColorRelation
        public int ColorId { get; set; }
        public Color Color { get; set; }
        #endregion

        #region CarRentalRelation
        public List<Rental> Rentals { get; set; }
        #endregion



    }
}
