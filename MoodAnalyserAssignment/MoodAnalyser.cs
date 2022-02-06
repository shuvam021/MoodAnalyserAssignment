using System;

namespace MoodAnalyserAssignment
{
    /// <summary>Project that detect Mood from user's posts</summary>
    public class MoodAnalyser
    {
        private readonly string _message;

        /// <summary>Default Constructor where null is assigned as default input</summary>
        public MoodAnalyser()
        {
            this._message = null;
        }

        /// <summary>Constructor for collecting user's input</summary>
        public MoodAnalyser(string msg)
        {
            this._message = msg;
        }

        /// <summary>Detect Mood from given input</summary>
        /// <returns>HAPPY/SAD depends on input</returns>
        public string AnalyseMood()
        {
            try
            {
                if (_message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodExceptionType.EmptyValueException,
                        ResponseMessage.EmptyValueErrorMessage);
                }
                else
                {
                    return this._message.ToLower().Contains("sad")
                        ? ResponseMessage.SadResponse
                        : ResponseMessage.HappyResponse;
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodExceptionType.NullException,
                    ResponseMessage.NullErrorMessage);
            }
        }
    }
}