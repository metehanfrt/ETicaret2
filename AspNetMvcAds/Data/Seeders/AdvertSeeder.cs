using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Data.Seeders
{
    public class AdvertSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var adverts = new List<Advert>()
            {
                new Advert() { Id = 1, UserId = 1, Title = "Kaliteli Hobi Aleti",
                    Description="toplamda 5 saat uçuş kullanıldı / 3 batarya ve diğer aksesuarları",
                    Price = 1200 , CreatedAt = DateTime.Now, },
                new Advert() { Id = 2, UserId = 2, Title = "Ürün 2", Description="", Price = 140000, CreatedAt = DateTime.Now, Location = "Ankara" },
                new Advert() { Id = 3, UserId = 1, Title = "Ürün 3", Description="", Price = 250, CreatedAt = DateTime.Now, Location = "İstanbul" },
                new Advert() { Id = 4, UserId = 2, Title = "Ürün 4", Description="", Price = 4543, CreatedAt = DateTime.Now, Location = "İzmir" }
            };
            modelBuilder.Entity<Advert>().HasData(adverts);


            modelBuilder.Entity<Advert>()
                .HasMany(p => p.Categories)
                .WithMany(p => p.Adverts)
                .UsingEntity(j => j.HasData(new[] {
                    new { AdvertsId = 1, CategoriesId = 1 },
                    new { AdvertsId = 2, CategoriesId = 2 },
                    new { AdvertsId = 3, CategoriesId = 3 },
                    new { AdvertsId = 4, CategoriesId = 4 }
                }));
        }

    }


}
