using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyserObj(string className, string constructor)
        {
            string pattern = "." + constructor + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodExceptionType.No_SUCH_CLASS,
                        ResponseMessage.ClassNotFoundResponse);
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodExceptionType.No_SUCH_METHOD,
                        ResponseMessage.MethodNotFoundResponse);
            }
        }
    }
}