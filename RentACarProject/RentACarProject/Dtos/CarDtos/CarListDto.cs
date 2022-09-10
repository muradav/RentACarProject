using System.Collections.Generic;

namespace RentACarProject.Dtos.CarDtos
{
    public class CarListDto
    {
        public int TotalCount { get; set; }
        public List<CarReturnDto> Items { get; set; }
    }
}
