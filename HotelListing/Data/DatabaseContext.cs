using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Bangladesh",
                    ShortName = "BD"
                },
                new Country
                {
                    Id = 2,
                    Name = "Saudi Arabia",
                    ShortName = "KSA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Egypt",
                    ShortName = "EGY"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Shonargaon",
                    Address = "Dhaka",
                    CountryID = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Taj",
                    Address = "Jedda",
                    CountryID = 2,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "HotelMishor",
                    Address = "Kabul",
                    CountryID = 3,
                    Rating = 4.3
                }
                );
        }


    }
}
