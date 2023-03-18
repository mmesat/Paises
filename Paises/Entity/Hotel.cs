namespace Paises.Entity
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<CountryHotel> CountryHotels { get; set; }
    }
}
