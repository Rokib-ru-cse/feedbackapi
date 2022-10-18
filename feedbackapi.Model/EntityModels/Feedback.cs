using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public ApplicationUser? UpdatedBy { get; set; }
        public string? UpdatedById { get; set; }
        public Provider Provider { get; set; }
        public int ProviderId { get; set; }
        public string? Currency { get; set; }
        public int? Price { get; set; }

    }
}
