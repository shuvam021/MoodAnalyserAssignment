namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            return message.ToLower().Contains("happy") ? "happy" : "sad";
        }
    }
}