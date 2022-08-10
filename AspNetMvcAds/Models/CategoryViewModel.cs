using AspNetMvcAds.Data;

namespace AspNetMvcAds.Models
{
    public class CategoryViewModel
    {
        public List<Category> AllCategories { get; set; }
        public List<AdvertCategoryStatisticModel> AllAdvertCategories { get; set; }
    }
}
