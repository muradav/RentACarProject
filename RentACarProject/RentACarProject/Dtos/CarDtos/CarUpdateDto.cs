using Microsoft.AspNetCore.Http;

namespace RentACarProject.Dtos.CarDtos
{
    public class CarUpdateDto
    {
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string FuelType { get; set; }
        public string TransmissionType { get; set; }
        public int PassengerCount { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
