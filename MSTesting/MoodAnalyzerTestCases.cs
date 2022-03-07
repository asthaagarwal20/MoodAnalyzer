using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MSTesting
{
    [TestClass]
    public class MoodAnalyzerTestCases
    {
        [TestMethod]
        public void GivenNullMood_SoReturnHappy()
        {
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            string mood = null;
            string expected = "happy";
            string actual=moodAnalyzer.AnalyzeMood(mood);
            Assert.AreEqual(expected, actual);

        }
    }
}