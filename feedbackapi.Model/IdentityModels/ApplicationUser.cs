using Microsoft.AspNetCore.Identity;

namespace feedbackapi.Model.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Image { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public int? ZipCode { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Website { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string? Point { get; set; }
        public string? WorkAs { get; set; }
    }
}