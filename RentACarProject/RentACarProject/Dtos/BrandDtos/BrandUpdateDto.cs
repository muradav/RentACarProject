using Microsoft.AspNetCore.Http;

namespace RentACarProject.Dtos.BrandDtos
{
    public class BrandUpdateDto
    {
        public string Name { get; set; }
        public IFormFile Photo { get; set; }
    }
}
