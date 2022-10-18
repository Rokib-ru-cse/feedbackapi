using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class Like
    {
        public int Id { get; set; }
        public bool isLike { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Feedback Feedback { get; set; }
        public int FeedbackId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
