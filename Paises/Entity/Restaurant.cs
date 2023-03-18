namespace Paises.Entity
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<CountryRestaurant> CountryRestaurants { get; set; }
    }
}
