namespace feedbackapi.Model.EntityModels
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string Image { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public Feedback Feedback { get; set; }
        public int FeedbackId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
