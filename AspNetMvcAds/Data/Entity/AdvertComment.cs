namespace AspNetMvcAds.Data
{
    public class AdvertComment : AuditEntity
    {
        public int Id { get; set; }

        public int AdvertId { get; set; }

        public int? UserId { get; set; }

        public string? Comment { get; set; }

        public int StarRating { get; set; }

        public bool IsActive { get; set; }

        // Navigation
        public Advert Advert { get; set; }

        public User User { get; set; }
    }
}