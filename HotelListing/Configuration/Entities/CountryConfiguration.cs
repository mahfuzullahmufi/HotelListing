using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configuration.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
