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
            MoodAnalyser moodObj = new MoodAnalyser();

            //act
            string actual = moodObj.analyse_mood(message);

            //assert
            Assert.AreEqual(expected, actual);
            
        }
        
    }
}