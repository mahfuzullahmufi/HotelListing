using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage ="Country Name Is Too Large")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage ="Short Country Name Is Too Large")]
        public string ShortName { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Countries { get; set; }
    }
}

