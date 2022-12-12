namespace API_Mobile.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string MainPicture { get; set; } = String.Empty;
        public IEnumerable<string>? Pictures { get; set; }
    }
}
