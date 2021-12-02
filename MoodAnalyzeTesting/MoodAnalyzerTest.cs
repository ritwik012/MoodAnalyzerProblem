using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        MoodAnalyzer mood;
        [SetUp]
        public void Setup()
        {
            this.mood = new MoodAnalyzer();
        }
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string output = "SAD";
            string result = mood.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string output = "HAPPY";
            string result = mood.AnalyzeMood("I am in Any Mood");
            Assert.AreEqual(output, result);
        }
    }
}