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
    }
}