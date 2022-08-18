using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("30","15", "450")]
        [DataRow("20", "10", "200")]
        [DataRow("10", "15", "150")]
        public void TestMethod1(string length, string width, string expectedResult)
        {
            int l = Int32.Parse(length);
            int w = Int32.Parse(width);
            int er = Int32.Parse(expectedResult);

            var areaCalc = new Shapes();
            var area = areaCalc.GetArea(l,w);
            Assert.AreEqual(er, area);
        }
    }
}
