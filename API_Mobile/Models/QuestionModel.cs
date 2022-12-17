namespace API_Mobile.Models
{
    public class QuestionModel
    {
        public string Question { get; set; } = String.Empty;
        public IEnumerable<string> Responses { get; set; } = new List<string>();
        public string CorrectResponse { get; set; } = String.Empty;
    }
}
