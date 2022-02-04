using System;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        private readonly string _message;

        public MoodAnalyser()
        {
            this._message = null;
        }

        public MoodAnalyser(string msg)
        {
            this._message = msg;
        }
        public string AnalyseMood()
        {
            try
            {
                return this._message.ToLower().Contains("sad") ? "SAD" : "HAPPY";
            }
            catch (NullReferenceException e)
            {
                return "HAPPY";
            }
        }
    }
}