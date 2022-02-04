using System;

namespace MoodAnalyserAssignment
{
    class Program
    {
        private static MoodAnalyser _app;
        static void Main()
        {
            _app = new MoodAnalyser("I am in Happy mood");
            Console.WriteLine(_app.AnalyseMood());
            _app = new MoodAnalyser("I am in sad mood");
            Console.WriteLine(_app.AnalyseMood());
            _app = new MoodAnalyser("I am in any mood");
            Console.WriteLine(_app.AnalyseMood());
            _app = new MoodAnalyser();
            Console.WriteLine(_app.AnalyseMood());
        }
    }
}