using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAssignment;

namespace TestMoodAnalysis
{
    /// <summary>Test cases for MoodAnalyserAssignment.MoodAnalyser class</summary>
    [TestClass]
    public class TestMoodAnalyser
    {
        private MoodAnalyser _app;
        private string happyResponse = "HAPPY";
        private string sadResponse = "SAD";
        
        /// <summary>Testing for possible outcomes of AnalyseMood() with respect to message parameter</summary>
        [TestMethod, TestCategory(@"AnalyseMood() result")]
        public void TestAnalyseMoodMethodResult()
        {
            _app = new MoodAnalyser("I am in any mood");
            Assert.AreEqual(_app.AnalyseMood(), this.happyResponse);
            _app = new MoodAnalyser("I am in sad mood");
            Assert.AreEqual(_app.AnalyseMood(), this.sadResponse);
        }
        
        /// <summary>Testing for outcomes of AnalyseMood() with null input</summary>
        [TestMethod, TestCategory(@"AnalyseMood() with null input")]
        public void TestAnalyseMoodMethodWithNullInput()
        {
            _app = new MoodAnalyser();
            Assert.AreEqual(_app.AnalyseMood(), this.happyResponse);
        }
    }
}