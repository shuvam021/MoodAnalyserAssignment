using System;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyserException : Exception
    {
        public MoodExceptionType type;

        public MoodAnalyserException(MoodExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}