using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAssignment;

namespace TestMoodAnalysis
{
    /// <summary>Test cases for MoodAnalyserAssignment.MoodAnalyser class</summary>
    [TestClass]
    public class TestMoodAnalyser
    {
        private MoodAnalyser _app;
        
        /// <summary>Testing for possible outcomes of AnalyseMood() with respect to message parameter</summary>
        [TestMethod, TestCategory(@"AnalyseMood() result")]
        public void TestAnalyseMoodMethodResult()
        {
            _app = new MoodAnalyser("I am in any mood");
            Assert.AreEqual(ResponseMessage.HappyResponse, _app.AnalyseMood());
            _app = new MoodAnalyser("I am in sad mood");
            Assert.AreEqual(ResponseMessage.SadResponse, _app.AnalyseMood());
        }
        
        /// <summary>Testing for outcomes of AnalyseMood() with null input</summary>
        [TestMethod, TestCategory(@"AnalyseMood() with null input")]
        public void TestAnalyseMoodMethodWithNullInput()
        {
            _app = new MoodAnalyser();
            try
            {
                _app.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(ResponseMessage.NullErrorMessage, e.Message);
            }
        }
        /// <summary>Testing for outcomes of AnalyseMood() with no input</summary>
        [TestMethod, TestCategory(@"AnalyseMood() with empty string")]
        public void TestAnalyseMoodMethodWithNoInput()
        {
            _app = new MoodAnalyser("");
            try
            {
                _app.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(ResponseMessage.EmptyValueErrorMessage, e.Message);
            }
        }
    }
}