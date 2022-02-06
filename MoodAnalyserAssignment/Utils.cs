namespace MoodAnalyserAssignment
{
    /// <summary>Reusable Response message for Mood Analyser Project</summary>
    public static class ResponseMessage
    {
        public const string HappyResponse = "HAPPY";
        public const string SadResponse = "SAD";
        public const string NullErrorMessage = "Value should not be null";
        public const string EmptyValueErrorMessage = "Value can not be empty";
        public const string ClassNotFoundResponse = "Class not found";
        public const string MethodNotFoundResponse = "Method not found";

    }

    /// <summary>Collection of Custom Exception Types for Mood Analyser Project</summary>
    public enum MoodExceptionType
    {
        NullException,
        EmptyValueException,
        No_SUCH_CLASS,
        No_SUCH_METHOD,
    }
}