namespace API_Mobile.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string MainPicture { get; set; } = String.Empty;
        public List<string>? Pictures { get; set; } = new List<string>();
        public float Distance { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; } = String.Empty;
        public IEnumerable<QuestionModel>? Questions { get; set; }
    }
}
