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
        public static object CreateMoodAnalyserParameterizedObj(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                if (type.Name.Equals(className) || type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] {typeof(string)});
                        return constructorInfo.Invoke(new object[] {message});
                    }
                    else
                    {
                        throw new MoodAnalyserException(
                            MoodExceptionType.No_SUCH_METHOD,
                            ResponseMessage.MethodNotFoundResponse
                            );
                    }
                }
                else
                {
                    throw new MoodAnalyserException(
                        MoodExceptionType.No_SUCH_CLASS,
                        ResponseMessage.ClassNotFoundResponse
                        );
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserAssignment.MoodAnalyser");
                object moodAnalyserObj = MoodAnalyserFactory.CreateMoodAnalyserParameterizedObj(
                    "MoodAnalyserAssignment.MoodAnalyser",
                    "MoodAnalyser",
                    message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyserObj, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodExceptionType.No_SUCH_METHOD,
                    ResponseMessage.MethodNotFoundResponse);
            }
        }

        public static string SetField(string message, string fieldName)
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                Type type = typeof(MoodAnalyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (message == null)
                {
                    throw new MoodAnalyserException(
                        MoodExceptionType.NoSuchField, "Message should not be mull");
                }

                field.SetValue(moodAnalyser, message);
                return moodAnalyser.message;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(
                    MoodExceptionType.NoSuchField, ResponseMessage.NoSuchFieldResponse);
            }
        }
    }
}
