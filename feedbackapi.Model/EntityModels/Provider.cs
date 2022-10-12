namespace feedbackapi.Model.EntityModels
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Address { get; set; }
        public string? Website { get; set; }
        public string? Facebook { get; set; }
        public string? Youtube { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Feedback Feedback { get; set; }
        public int FeedbackId { get; set; }

    }
}
