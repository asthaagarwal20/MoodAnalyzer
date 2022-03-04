using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program program = new Program();
            Assert.AreEqual("happy", program.Test("I am in any mood"));

        }
    }
}