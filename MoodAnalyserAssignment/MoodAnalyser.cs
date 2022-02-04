using System;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            try
            {
                return message.ToLower().Contains("happy") ? "happy" : "sad";
            }
            catch (NullReferenceException e)
            {
                return "happy";
            }
        }
    }
}