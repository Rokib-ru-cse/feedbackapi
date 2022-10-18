using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ApplicationUser? UpdatedBy { get; set; }
        public string? UpdatedById { get; set; }
    }
}
