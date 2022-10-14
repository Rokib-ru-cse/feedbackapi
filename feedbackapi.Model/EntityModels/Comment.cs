using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Feedback Feedback { get; set; }
        public int FeedbackId { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public ApplicationUser? UpdatedBy { get; set; }
        public string? UpdatedById { get; set; }

    }
}
