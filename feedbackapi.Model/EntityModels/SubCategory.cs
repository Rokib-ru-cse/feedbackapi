using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public ApplicationUser? UpdatedBy { get; set; }
        public string? UpdatedById { get; set; }
    }
}
