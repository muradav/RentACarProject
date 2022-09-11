using AutoMapper;
using RentACarProject.Dtos.CarDtos;
using RentACarProject.Entity;

namespace RentACarProject.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Color, CarColorDto>();
            CreateMap<Brand, CarBrandDto>()
                .ForMember(d => d.ImageUrl, map => map.MapFrom(s => "https://localhost:44352/assets/img/brand/" + s.ImageUrl));
            CreateMap<CarImage, CarImageCarDto>()
                .ForMember(d => d.ImageUrl, map => map.MapFrom(s => "https://localhost:44352/assets/img/car/" + s.ImageUrl));
            CreateMap<Car, CarReturnDto>();
        }
    }
}
