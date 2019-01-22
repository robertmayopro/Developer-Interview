using NUnit.Framework;
using Mednax.DeveloperInterview.TDD;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        private FizzBuzz _systemUnderTest = new FizzBuzz();

        [Test]
        public void GivenANumberNotAMultipleOfThreeOrFiveShouldEmitNumber()
        {
            int input = 4;
            string expected = "4";
            string actual = _systemUnderTest.Emit(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenANumberThatIsAMultipleOfBothThreeAndFiveShouldEmitFizzBuzz()
        {
            int input = 15;
            string expected = "FizzBuzz";
            string actual = _systemUnderTest.Emit(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenANumberThatIsOnlyAMultipleOfFiveShouldEmitBuzz()
        {
            int input = 5;
            string expected = "Buzz";
            string actual = _systemUnderTest.Emit(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenANumberThatIsOnlyAMultipleOfThreeShouldEmitFizz()
        {
            int input = 3;
            string expected = "Fizz";
            string actual = _systemUnderTest.Emit(input);
            Assert.AreEqual(expected, actual);
        }
    }
}