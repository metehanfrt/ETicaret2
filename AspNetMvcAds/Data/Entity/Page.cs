using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcAds.Data
{
    public class Page : AuditEntity
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string? Title { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string? Content { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? PageImageUrl { get; set; }

        public bool IsActive { get; set; }
    }
}
