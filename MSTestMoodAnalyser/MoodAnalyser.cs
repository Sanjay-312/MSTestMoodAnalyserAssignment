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
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood can not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch(Exception ) 
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Invalid Mood");
            }
            

        }

    }
}
