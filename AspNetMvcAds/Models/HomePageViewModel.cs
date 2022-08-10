using AspNetMvcAds.Data;

namespace AspNetMvcAds.Models
{
    public class HomePageViewModel
    {
        public List<Category> PopularCategories { get; set; }
        public List<Advert> TrendingAdverts { get; set; }
    }
}
