using System;

namespace MoodAnalyserAssignment
{
    class Program
    {
        static void Main()
        {
             var app = new MoodAnalyser("I am in Happy mood");
            Console.WriteLine(app.AnalyseMood());
        }
    }
}