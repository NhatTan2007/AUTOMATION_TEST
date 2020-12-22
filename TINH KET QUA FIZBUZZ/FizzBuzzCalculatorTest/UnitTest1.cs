using NUnit.Framework;
using TINH_KET_QUA_FIZBUZZ;

namespace FizzBuzzCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalcualtorFizzBuzzTest_01()
        {
            Assert.AreEqual("Fizz", FizzBuzzCalculator.CalculateFizzBuzz(9));
        }

        [Test]
        public void CalcualtorFizzBuzzTest_02()
        {
            Assert.AreEqual("Buzz", FizzBuzzCalculator.CalculateFizzBuzz(20));
        }

        [Test]
        public void CalcualtorFizzBuzzTest_03()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzCalculator.CalculateFizzBuzz(45));
        }


        [Test]
        public void CalcualtorFizzBuzzTest_04()
        {
            Assert.AreEqual("19", FizzBuzzCalculator.CalculateFizzBuzz(19));
        }

        //FizzBuzz Translate
        [Test]
        public void FizzBuzzTranslateTest_01()
        {
            Assert.AreEqual("19", FizzBuzzTranslate.TranslateToFizzBuzz(19));
        }
        [Test]
        public void FizzBuzzTranslateTest_02()
        {
            Assert.AreEqual("Fizz", FizzBuzzTranslate.TranslateToFizzBuzz(233));
        }
        [Test]
        public void FizzBuzzTranslateTest_03()
        {
            Assert.AreEqual("Buzz", FizzBuzzTranslate.TranslateToFizzBuzz(457));
        }

        //Translate Number test
        [Test]
        public void TranslateNumberTest_01()
        {
            Assert.AreEqual("Mười Chín", FizzBuzzTranslate.TranslateNumber(19));
        }
        [Test]
        public void TranslateNumberTest_02()
        {
            Assert.AreEqual("Hai mươi", FizzBuzzTranslate.TranslateNumber(20));
        }
        [Test]
        public void TranslateNumberTest_03()
        {
            Assert.AreEqual("Bốn mươi mốt", FizzBuzzTranslate.TranslateNumber(41));
        }
        [Test]
        public void TranslateNumberTest_04()
        {
            Assert.AreEqual("Không", FizzBuzzTranslate.TranslateNumber(0));
        }
        [Test]
        public void TranslateNumberTest_05()
        {
            Assert.AreEqual("Mười lăm", FizzBuzzTranslate.TranslateNumber(15));
        }
        [Test]
        public void TranslateNumberTest_06()
        {
            Assert.AreEqual("Hai mươi lăm", FizzBuzzTranslate.TranslateNumber(25));
        }

    }
}