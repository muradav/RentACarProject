using RentACarProject.Entities;
using System.Collections.Generic;

namespace RentACarProject.Dtos.CarDtos
{
    public class CarReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string FuelType { get; set; }
        public string TransmissionType { get; set; }
        public int PassengerCount { get; set; }
        public CarColorDto Color { get; set; }
        public CarBrandDto Brand { get; set; }
        public List<CarImageCarDto> CarImages { get; set; }

    }

    public class CarColorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CarBrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class CarImageCarDto
    {
        public string ImageUrl { get; set; }
    }

    

}
