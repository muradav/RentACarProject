using System.Collections.Generic;

namespace RentACarProject.Dtos.BrandDtos
{
    public class BrandListDto
    {
        public int TotalCount { get; set; }
        public List<BrandReturnDto> Items { get; set; }
    }
}
