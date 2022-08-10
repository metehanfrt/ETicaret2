using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Data.Seeders
{
    public class CategorySeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "Emlak", Description="", CreatedAt = DateTime.Now, IsPopular = true, IconClass = "fa fa-home icon-bg-3" },
                new Category() { Id = 2, Name = "İkinci El",  Description="", CreatedAt = DateTime.Now, IsPopular = true, IconClass = "fa fa-apple icon-bg-2" },
                new Category() { Id = 3, ParentCategoryId = 1, Name = "Konut", Description="", IsPopular = true, CreatedAt = DateTime.Now },
                new Category() { Id = 4, ParentCategoryId = 1, Name = "Arsa", Description="", IsPopular = true, CreatedAt = DateTime.Now },
                new Category() { Id = 5, Name = "Araba", Description="", CreatedAt = DateTime.Now, IsPopular = true, IconClass = "fa fa-car icon-bg-6" },
                new Category() { Id = 6, ParentCategoryId = 5, Name = "SUV", Description="", IsPopular = true, CreatedAt = DateTime.Now },
                new Category() { Id = 7, Name = "Giyim", Description="", IsPopular = true, CreatedAt = DateTime.Now, IconClass = "fa fa-shopping-basket icon-bg-4" },
                new Category() { Id = 8, Name = "İş İlanları", Description="", IsPopular = true, CreatedAt = DateTime.Now, IconClass = "fa fa-briefcase icon-bg-5" },
                new Category() { Id = 9, Name = "Elektronik", Description="", IsPopular = true, CreatedAt = DateTime.Now, IconClass = "fa fa-laptop icon-bg-1" },
                new Category() { Id = 10, ParentCategoryId = 9, Name = "Cep Telefonu", Description="", IsPopular = true, CreatedAt = DateTime.Now, IconClass = "fa fa-laptop icon-bg-1" },
            };
            modelBuilder.Entity<Category>().HasData(categories);
        }

    }




}
