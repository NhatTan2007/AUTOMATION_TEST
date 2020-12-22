using NUnit.Framework;
using TINH_NGAY_TIEP_THEO;
using System;

namespace NextDayCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        //Ngày bình thường trong tháng
        [Test]
        public void CaseTest_01()
        {
            DateTime inputDate = new DateTime(2020, 12, 20);
            Assert.AreEqual("21/12/2020", NextDayCalculator.NextDay(inputDate));
        }
        //Ngày cuối năm
        [Test]
        public void CaseTest_02()
        {
            DateTime inputDate = new DateTime(2020, 12, 31);
            Assert.AreEqual("1/1/2021", NextDayCalculator.NextDay(inputDate));
        }
        //Ngày cuối tháng có 30 ngày
        [Test]
        public void CaseTest_03()
        {
            DateTime inputDate = new DateTime(2020, 09, 30);
            Assert.AreEqual("1/10/2020", NextDayCalculator.NextDay(inputDate));
        }
        //Ngày cuối tháng có 31 ngày
        [Test]
        public void CaseTest_04()
        {
            DateTime inputDate = new DateTime(2020, 10, 31);
            Assert.AreEqual("1/11/2020", NextDayCalculator.NextDay(inputDate));
        }
        //Ngày 28 trong tháng 2 năm nhuận
        [Test]
        public void CaseTest_05()
        {
            DateTime inputDate = new DateTime(2020, 02, 28);
            Assert.AreEqual("29/2/2020", NextDayCalculator.NextDay(inputDate));
        }
        //Ngày 29 trong tháng 2 năm nhuận
        [Test]
        public void CaseTest_06()
        {
            DateTime inputDate = new DateTime(2020, 02, 29);
            Assert.AreEqual("1/3/2020", NextDayCalculator.NextDay(inputDate));
        }
        [Test]
        public void CaseTest_07()
        {
            DateTime inputDate = new DateTime(1600, 02, 29);
            Assert.AreEqual("1/3/1600", NextDayCalculator.NextDay(inputDate));
        }
        //Ngày 28 trong tháng 2 năm không nhuận
        [Test]
        public void CaseTest_09()
        {
            DateTime inputDate = new DateTime(2017, 02, 28);
            Assert.AreEqual("1/3/2017", NextDayCalculator.NextDay(inputDate));
        }
        [Test]
        public void CaseTest_10()
        {
            DateTime inputDate = new DateTime(1700, 02, 28);
            Assert.AreEqual("1/3/1700", NextDayCalculator.NextDay(inputDate));
        }
    }
}