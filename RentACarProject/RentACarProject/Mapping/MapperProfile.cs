using AutoMapper;
using RentACarProject.Dtos.BrandDtos;
using RentACarProject.Dtos.CarDtos;
using RentACarProject.Entities;

namespace RentACarProject.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            #region CarMap

            CreateMap<Color, CarColorDto>();
            CreateMap<Brand, CarBrandDto>()
                .ForMember(d => d.ImageUrl, map => map.MapFrom(s => "https://localhost:44352/assets/img/brand/" + s.ImageUrl));
            CreateMap<CarImage, CarImageCarDto>()
                .ForMember(d => d.ImageUrl, map => map.MapFrom(s => "https://localhost:44352/assets/img/car/" + s.ImageUrl));
            CreateMap<Car, CarReturnDto>();

            #endregion

            #region BrandMap

            CreateMap<Brand, BrandReturnDto>()
                .ForMember(d => d.ImageUrl, map => map.MapFrom(s => "https://localhost:44352/assets/img/brand/" + s.ImageUrl)); ;

            #endregion
        }
    }
}
