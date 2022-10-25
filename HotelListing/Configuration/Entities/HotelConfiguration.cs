using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configuration.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
