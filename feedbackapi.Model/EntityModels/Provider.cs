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
        public string? Youtube { get; set; }
        public Feedback Feedback { get; set; }
        public int FeedbackId { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }

    }
}
