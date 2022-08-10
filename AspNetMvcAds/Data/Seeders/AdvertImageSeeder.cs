using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Data.Seeders
{
    public class AdvertImageSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var advertimages = new List<AdvertImage>()
            {
                new AdvertImage() { Id = 1, AdvertId = 1, ImageUrl = "products-1.jpg"},
                new AdvertImage() { Id = 2, AdvertId = 2, ImageUrl = "products-2.jpg"},
                new AdvertImage() { Id = 3, AdvertId = 3, ImageUrl = "products-3.jpg"},
                new AdvertImage() { Id = 4, AdvertId = 4, ImageUrl = "products-4.jpg"},

                new AdvertImage() { Id = 5, AdvertId = 1, ImageUrl = "products-1.jpg"},
                new AdvertImage() { Id = 6, AdvertId = 2, ImageUrl = "products-2.jpg"},
                new AdvertImage() { Id = 7, AdvertId = 3, ImageUrl = "products-3.jpg"},
                new AdvertImage() { Id = 8, AdvertId = 4, ImageUrl = "products-4.jpg"}

            };

            modelBuilder.Entity<AdvertImage>().HasData(advertimages);
        }
    }
}
