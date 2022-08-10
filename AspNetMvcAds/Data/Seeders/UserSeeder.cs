using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Data.Seeders
{
    public class UserSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var users = new List<User>()
            {
                new User() { Id = 1, Email = "atakan@gmail.com", Password = "123", Name = "Atakan", ProfileImagePath = "/images/user/user-thumb.jpg" },
                new User() { Id = 2, Email = "mahmut@gmail.com", Password = "123", Name = "Mahmut", ProfileImagePath = "/images/user/user-thumb.jpg" },
            };
            modelBuilder.Entity<User>().HasData(users);
        }
    }

}
