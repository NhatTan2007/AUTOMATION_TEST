using NUnit.Framework;
using PHAN_LOAI_TAM_GIAC;

namespace TriangleClassifierTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2,2,2)]
        [TestCase(4,4,4)]
        [TestCase(10,10,10)]
        public void TriangleTypeTest_01(int sideA, int sideB, int sideC)
        {
            Assert.AreEqual("This is an Equilateral Triangle", TriangleClassifier.CheckTypeOfTriangle(sideA, sideB, sideC));
        }

        [TestCase(2, 2, 3)]
        [TestCase(2, 4, 4)]
        [TestCase(3, 5, 3)]
        public void TriangleTypeTest_02(int sideA, int sideB, int sideC)
        {
            Assert.AreEqual("This is an Isosceles Triangle", TriangleClassifier.CheckTypeOfTriangle(sideA, sideB, sideC));
        }

        [TestCase(2, 4, 3)]
        [TestCase(5, 7, 9)]
        [TestCase(6, 2, 7)]
        public void TriangleTypeTest_03(int sideA, int sideB, int sideC)
        {
            Assert.AreEqual("This is a Scalene Triangle", TriangleClassifier.CheckTypeOfTriangle(sideA, sideB, sideC));
        }

        [TestCase(2, 7, 3)]
        [TestCase(5, 2, 9)]
        [TestCase(3, 2, 7)]
        public void TriangleTypeTest_04(int sideA, int sideB, int sideC)
        {
            Assert.AreEqual("This is not a Triangle", TriangleClassifier.CheckTypeOfTriangle(sideA, sideB, sideC));
        }
    }
}