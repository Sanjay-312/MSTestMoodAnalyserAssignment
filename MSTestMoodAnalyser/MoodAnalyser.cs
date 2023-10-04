using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestMoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser() { }

        public MoodAnalyser(string message)
        {
            this.message=message;

        }
        
        public string analyse_mood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch
            {
                return "HAPPY";
            }
            

        }

    }
}
