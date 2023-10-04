using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestMoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }
        public string analyse_mood()
        {
            if(this.message.Contains("Sad"))
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
