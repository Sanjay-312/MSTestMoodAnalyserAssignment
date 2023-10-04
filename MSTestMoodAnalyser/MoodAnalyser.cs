using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestMoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        
        public string analyse_mood(string message)
        {
            if(message.Contains("Sad"))
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
