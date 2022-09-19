using System.Collections.Generic;

namespace RentACarProject.Dtos.RentalDtos
{
    public class RentalListDto
    {
        public int TotalCount { get; set; }
        public List<RentalReturnDto> Items { get; set; }
    }
}
