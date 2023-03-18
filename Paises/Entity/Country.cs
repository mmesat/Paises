namespace Paises.Entity
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Language { get; set; }
        public List<CountryRestaurant> CountryRestaurants { get; set; }
        public List<CountryHotel> CountryHotels { get; set; }
    }

    public class CountryRestaurant
    {
        public int IdCountry { get; set; }
        public Country country { get; set; }
        public int IdRestaurant { get; set; }
        public Restaurant restaurant { get; set; }
    }

    public class CountryHotel
    {
        public int IdCountry { get; set; }
        public Country country { get; set; }
        public int IdHotel { get; set; }
        public Hotel hotel { get; set; }
    }
}
