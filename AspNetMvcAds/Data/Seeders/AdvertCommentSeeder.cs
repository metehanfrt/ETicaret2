using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Data.Seeders
{
    public class AdvertCommentSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var advertcomments = new List<AdvertComment>()
            {
                new AdvertComment() {
                    Id = 1, UserId = 1, AdvertId = 1 ,
                    Comment ="Ürün hakkında satıcı ile görüşmek için mesaj attım dönüş yapmadı!",
                    StarRating = 3,
                    CreatedAt = DateTime.Now
                },
                new AdvertComment() {
                    Id = 2, UserId = 1, AdvertId = 1 ,
                    Comment ="Ürün hakkında satıcı ile görüşmek için mesaj attım dönüş yapmadı!",
                    StarRating = 4,
                    CreatedAt = DateTime.Now
                },
                new AdvertComment() {
                    Id = 3, UserId = 2,AdvertId = 2 ,
                    Comment = "Ürünle alakalı hiç bir açıklama bulunmamaktadır.",
                    StarRating = 4,
                    CreatedAt = DateTime.Now,
                },
                new AdvertComment() {
                    Id = 4, UserId = 2,AdvertId = 2 ,
                    Comment = "Ürünle alakalı hiç bir açıklama bulunmamaktadır.",
                    StarRating = 2,
                    CreatedAt = DateTime.Now,
                }
            };
            modelBuilder.Entity<AdvertComment>().HasData(advertcomments);

        }
    }


}
