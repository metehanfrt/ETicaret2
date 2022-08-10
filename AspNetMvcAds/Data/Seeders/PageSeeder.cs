using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Data.Seeders
{
    public class PageSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var list = new List<Page>()
            {
                new Page() { Id = 1, Title = "Hakkımızda", Content = "Hakkımızda", CreatedAt = DateTime.Now, PageImageUrl = "https://images.unsplash.com/photo-1621609764095-b32bbe35cf3a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=764&q=80" },
                new Page() { Id = 2, Title = "İnsan Kaynakları", Content = "İnsan Kaynakları", CreatedAt = DateTime.Now, PageImageUrl = "https://images.unsplash.com/photo-1648571867396-ae1221b5882e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80" },
            };
            modelBuilder.Entity<Page>().HasData(list);
        }
    }
}