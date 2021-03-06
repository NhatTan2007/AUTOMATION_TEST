using NUnit.Framework;
using NUnitTest;

namespace NTest
{
    public class Tests
    {
        private MyMath myMath;
        [SetUp]
        public void Setup()
        {
            myMath = new MyMath();
        }

        [Test]
        public void Sum_01()
        {
            int Total = myMath.Sum(10, 20);
            Assert.AreEqual(30, Total);
        }
        [Test]
        public void Sum_02()
        {
            int Total = myMath.Sum(10, 20);
            Assert.AreNotEqual(31, Total);
        }
        [TestCase(50,50)]
        [TestCase(100,0)]
        [TestCase(150,-50)]
        public void Sum_03(int n1, int n2)
        {
            Assert.AreEqual(100, myMath.Sum(n1,n2));
        }
    }
}