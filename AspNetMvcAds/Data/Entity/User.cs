using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcAds.Data
{
    public class User : AuditEntity
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Column(TypeName = "varchar(200)")]
        public string? Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Address { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Phone { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? ProfileImagePath { get; set; }


        // Navigations
        public List<Advert> Adverts { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
