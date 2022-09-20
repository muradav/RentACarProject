using System.Collections.Generic;

namespace RentACarProject.Dtos.CarImageDtos
{
    public class CarImageListDto
    {
        public int TotalCount { get; set; }
        public List<CarImageReturnDto> Items { get; set; }
    }
}
