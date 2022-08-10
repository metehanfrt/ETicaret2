using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcAds.Data
{
    public class Category
    {
        public int Id { get; set; }

        public int? ParentCategoryId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Description { get; set; }

        public bool IsPopular { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? IconClass { get; set; }

        public DateTime CreatedAt { get; internal set; }

        // Navigation
        public List<Advert> Adverts { get; set; } = new List<Advert>();
        public Category ParentCategory { get; set; }
    }
}