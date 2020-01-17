using NUnit.Framework;

namespace ITI.Algorithms.Tests
{
    [TestFixture]
    public class Exercise2_1Tests
    {
        [TestCase("abc", false)]
        [TestCase("aaa", true)]
        [TestCase("abb", true)]
        [TestCase("cdefghc", true)]
        public void exercise1_works(string input, bool expected)
        {
            Assert.That(Exercise2_1.ContainsDuplicateChar(input), Is.EqualTo(expected));
        }
    }
}
