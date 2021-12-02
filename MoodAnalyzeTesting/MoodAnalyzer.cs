using System;

namespace MoodAnalyzerTesting
{
    internal class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        internal string AnalyzeMood()
        {
            throw new NotImplementedException();
        }
    }
}