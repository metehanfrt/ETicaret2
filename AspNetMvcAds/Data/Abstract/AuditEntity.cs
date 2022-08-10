using System.ComponentModel.DataAnnotations;

namespace AspNetMvcAds.Data
{
    public abstract class AuditEntity
    {
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
