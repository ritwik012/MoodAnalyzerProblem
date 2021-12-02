
using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        public object MoodAnalyzerFactory { get; private set; }

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            string output = "SAD";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in Any Mood";
            string output = "HAPPY";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = null;
            string output = "HAPPY";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenNullMood_WhenAnalyze_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = null;
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string result = mood.AnalyzeMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }
        [Test]
        public void GivenEmptyMood_WhenAnalyze_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = "";
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string result = mood.AnalyzeMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyzerClassName_ShouldReturnMoodAnalyzerObject()
        {
            object output = new MoodAnalyzer();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            output.Equals(obj);
        }
        [Test]
        public void GivenClassName_WhenImproper_ShouldThrowMoodAnalyzerException()
        {
            string output = "Class not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzing", "MoodAnalyzing");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(output, e.Message);
            }
        }
        [Test]
        public void GivenClass_WhenConstructorNotProper_ShouldThrowMoodAnalyzerException()
        {
            string output = "Constructor not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzing");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(output, e.Message);
            }
        }
    }
}