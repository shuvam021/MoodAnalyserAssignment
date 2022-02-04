using System;

namespace MoodAnalyserAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new MoodAnalyser();
            // Console.WriteLine(app.AnalyseMood("I am in Happy mood"));
            // Console.WriteLine(app.AnalyseMood("I am in sad mood"));
            // Console.WriteLine(app.AnalyseMood("I am in mood for doing nothing"));
            Console.WriteLine(app.AnalyseMood(null));
        }
    }
}