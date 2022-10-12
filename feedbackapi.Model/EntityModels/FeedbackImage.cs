namespace feedbackapi.Model.EntityModels
{
    public class FeedbackImage
    {
        public int Id { get; set; }
        public Feedback Feedback { get; set; }
        public int FeedbackId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
