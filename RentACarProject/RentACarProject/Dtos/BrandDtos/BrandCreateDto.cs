using Microsoft.AspNetCore.Http;

namespace RentACarProject.Dtos.BrandDtos
{
    public class BrandCreateDto
    {
        public string Name { get; set; }
        public IFormFile Photo { get; set; }
    }
}
