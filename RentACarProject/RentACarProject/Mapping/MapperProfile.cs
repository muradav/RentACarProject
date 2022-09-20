using AutoMapper;
using RentACarProject.Dtos.BrandDtos;
using RentACarProject.Dtos.CarDtos;
using RentACarProject.Dtos.CarImageDtos;
using RentACarProject.Dtos.ColorDtos;
using RentACarProject.Dtos.RentalDtos;
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

            #region ColorMap
            CreateMap<Color, ColorReturnDto>();
            #endregion

            #region RentalMap
            CreateMap<User, RentalUserDto>();
            CreateMap<Car, RentalCarDto>();
            CreateMap<Brand, RentalBrandDto>();
            CreateMap<Rental, RentalReturnDto>();
            #endregion

            #region CarImageMap
            CreateMap<CarImage, CarImageReturnDto>()
                .ForMember(d => d.ImageUrl, map => map.MapFrom(s => "https://localhost:44352/assets/img/car/" + s.ImageUrl)); ;
            #endregion
        }
    }
}
