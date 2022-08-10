namespace AspNetMvcAds.Data
{
    public class CategoryAdvert
    {
        public int CategoryId { get; set; }
        public int AdvertId { get; set; }

        public Advert Advert { get; set; }
        public Category? Category { get; set; }
    }
}