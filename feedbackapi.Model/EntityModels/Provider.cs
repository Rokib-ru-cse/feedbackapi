using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public ApplicationUser? UpdatedBy { get; set; }
        public string? UpdatedById { get; set; }

    }
}
