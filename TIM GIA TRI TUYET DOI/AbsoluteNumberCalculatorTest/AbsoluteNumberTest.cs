using NUnit.Framework;
using TIM_GIA_TRI_TUYET_DOI;

namespace AbsoluteNumberCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-2)]
        [TestCase(-14)]
        [TestCase(5)]
        [TestCase(3)]
        [TestCase(-9)]
        public void CalculateAbsoulteNumberTest_01(int number)
        {
            Assert.IsTrue(AbsoluteNumberCalculator.FindAbsolute(number) >= 0);
        }
    }
}