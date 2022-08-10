using AspNetMvcAds.Data;

namespace AspNetMvcAds.Models
{
    public class AdvertViewModel
    {
        public Advert Advert { get; set; }
                
        public List<AdvertImage> AdvertImages { get; set; }

        public List<AdvertComment> AdvertComments { get; set; }

        public List<Category> AdvertCategories { get; set; }
    }
}
