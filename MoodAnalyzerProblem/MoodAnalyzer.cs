
using System;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}