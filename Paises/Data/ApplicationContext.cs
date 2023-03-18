using Microsoft.EntityFrameworkCore;
using Paises.Entity;

namespace Paises.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //E-R Country Restaurant
            modelBuilder.Entity<CountryRestaurant>()
                .HasKey(cr => new { cr.IdRestaurant, cr.IdCountry });
            modelBuilder.Entity<CountryRestaurant>()
                .HasOne(cr => cr.country)
                .WithMany(c => c.CountryRestaurants)
                .HasForeignKey(cr => cr.IdCountry);
            modelBuilder.Entity<CountryRestaurant>()
                .HasOne(cr => cr.restaurant)
                .WithMany(r => r.CountryRestaurants)
                .HasForeignKey(bc => bc.IdRestaurant);
            //E-R Country Hotel
            modelBuilder.Entity<CountryHotel>()
                .HasKey(cr => new { cr.IdHotel, cr.IdCountry });
            modelBuilder.Entity<CountryHotel>()
                .HasOne(cr => cr.country)
                .WithMany(c => c.CountryHotels)
                .HasForeignKey(cr => cr.IdCountry);
            modelBuilder.Entity<CountryHotel>()
                .HasOne(cr => cr.hotel)
                .WithMany(r => r.CountryHotels)
                .HasForeignKey(bc => bc.IdHotel);
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<CountryRestaurant> countryRestaurants { get; set; }
        public DbSet<CountryHotel> countryHotel { get; set; }
    }
}
