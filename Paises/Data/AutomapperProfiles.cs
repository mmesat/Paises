using AutoMapper;
using Paises.DTOs;
using Paises.Entity;

namespace Paises.Data
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Restaurant, RestaurantDTO>().ReverseMap();
            CreateMap<CountryRestaurant, CountryRestaurantDTO>().ReverseMap();
            CreateMap<CountryHotel,CountryHotelDTO>().ReverseMap();

        }
    }
}
