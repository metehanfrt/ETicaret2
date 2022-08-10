using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcAds.Data
{
    public class AdvertImage
    {
        public int Id { get; set; }
        
        public int AdvertId { get; set; }

        public string ImageUrl { get; set; }

        // Navigation
        public Advert Advert { get; set; }
    }
}
