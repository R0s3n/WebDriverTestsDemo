using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] {5, 7});

            Assert.That(result == 12);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            int result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int result = Summator.Sum(new int[] { -7, -9 });

            Assert.That(result == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            int result = Summator.Sum(new int[] { });

            Assert.That(result == 0);
        }
    }
}