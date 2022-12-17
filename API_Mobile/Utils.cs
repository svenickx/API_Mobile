namespace API_Mobile
{
    public class Utils
    {
        public IEnumerable<string> GetPicturesPath(List<string> pictures)
        {
            for (int i = 0; i < pictures.Count; i++)
            {
                #if DEBUG
                pictures[i] = $"";
                #else
                pictures[i] = $"";
                #endif
            }
            return pictures;
        }
    }
}
