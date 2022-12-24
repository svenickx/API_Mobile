namespace API_Mobile.Models
{
    public class Discussion
    {
        public int PersonId { get; set; }
        public List<Message> messages { get; set; } = new();
    }
}
