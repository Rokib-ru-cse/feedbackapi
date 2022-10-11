namespace feedbackapi.Model.EntityModels
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Country Country { get; set; }

    }
}
