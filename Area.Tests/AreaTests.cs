using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Area;

namespace Area.Tests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void CircleTest()
        {
            double a = 10;
            double expected = 314.16;

            double s = CalcArea.Circle(a);

            Assert.AreEqual(expected, s);
        }
        [TestMethod]
        public void TriangleTest()
        {
            double a = 10;
            double b = 20;
            double c = 15;
            double expected = 72.62;

            double s = CalcArea.Triangle(a, b, c);

            Assert.AreEqual(expected, s);
        }
    }
}
