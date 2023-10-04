using MSTestMoodAnalyserAssignment;

namespace MoodTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void given_sad_should_return_sad()
        {
            //analyse
            string message = "I am in Sad Mood";
            string expected = "SAD";
            MoodAnalyser moodObj = new MoodAnalyser(message);

            //act
            string actual = moodObj.analyse_mood();

            //assert
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void given_anymood_should_return_happy()
        {
            //analyse
            string message = "I am in Any Mood";
            string expected = "HAPPY";
            MoodAnalyser moodObj = new MoodAnalyser(message);

            //act
            string actual = moodObj.analyse_mood();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}