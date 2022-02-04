using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAssignment;

namespace TestMoodAnalysis
{
    /// <summary>Test cases for MoodAnalyserAssignment.MoodAnalyser class</summary>
    [TestClass]
    public class TestMoodAnalyser
    {
        private MoodAnalyser _app;
        [TestInitialize]
        public void SetUp()
        {
            _app = new MoodAnalyser();
        }
        
        /// <summary>Testing for possible outcomes of AnalyseMood() with respect to message parameter</summary>
        [TestMethod, TestCategory(@"AnalyseMood() result")]
        public void TestAnalyseMoodMethodResult()
        {
            Assert.AreEqual(_app.AnalyseMood("I am in Happy mood"), "happy");
            Assert.AreEqual(_app.AnalyseMood("I am in sad mood"), "sad");
            Assert.AreEqual(_app.AnalyseMood("I am in mood for doing nothing"), "sad");
        }
        
        /// <summary>Testing for outcomes of AnalyseMood() with null input</summary>
        [TestMethod, TestCategory(@"AnalyseMood() with null input")]
        public void TestAnalyseMoodMethodWithNullInput()
        {
            Assert.AreEqual(_app.AnalyseMood(null), "happy");
        }
    }
}