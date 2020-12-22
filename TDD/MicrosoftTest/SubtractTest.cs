using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitTest;
namespace MicrosoftTest
{
    [TestClass]
    public class SubtractTest
    {
        private MyMath myMath;
        [TestMethod]
        public void SubtractTest_01()
        {
            myMath = new MyMath();
            Assert.AreEqual(10, myMath.Subtract(25, 15));
            //Assert.AreEqual<int>(5, myMath.Subtract(30,3));
        }
    }
}
