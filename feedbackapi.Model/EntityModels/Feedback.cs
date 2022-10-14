using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }

    }
}
