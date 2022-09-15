using System.Collections.Generic;

namespace RentACarProject.Dtos.ColorDtos
{
    public class ColorListDto
    {
        public int TotalCount { get; set; }
        public List<ColorReturnDto> Items { get; set; }
    }
}
