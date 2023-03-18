using Paises.Entity;

namespace Paises.DTOs
{
    public class CountryDTO
    {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Code { get; set; }
            public string? Language { get; set; }
            public List<CountryRestaurantDTO> CountryRestaurants { get; set; }
            public List<CountryHotelDTO> CountryHotels { get; set; }

    }

    public class CountryRestaurantDTO
    {
        public RestaurantDTO restaurant { get; set; }
    }

    public class CountryHotelDTO
    {
        public HotelDTO hotel { get; set; }
    }
}
