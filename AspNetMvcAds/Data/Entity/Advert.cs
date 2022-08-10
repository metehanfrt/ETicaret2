using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcAds.Data
{
    public class Advert : AuditEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Title { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        public string? SubTitle { get; set; }

        [Display(Name = "Açıklama")]
        [Column(TypeName = "ntext")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        public double Price { get; set; }

        public int ViewCount { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Location { get; set; }

        // Navigation
        public User? User { get; set; }

        public List<AdvertComment> AdvertComments { get; set; } = new List<AdvertComment>();

        public List<AdvertImage> AdvertImages { get; set; } = new List<AdvertImage>();

        public List<Category> Categories { get; set; } = new List<Category>();


    }
}