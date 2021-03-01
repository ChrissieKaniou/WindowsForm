using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WindowsFormsApp
{
    [TestFixture]
    public class TriangleAreaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriAreaTest()
        {
            TriangleArea triangle = new TriangleArea();
            double x = 6;
            double y = 8;
            double z = 10;
            double expectedValue = 24;
            double actualValue = triangle.TriArea(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void TriAreaTest2()
        {
            TriangleArea triangle = new TriangleArea();
            double x = 7;
            double y = 9;
            double z = 11;
            double expectedValue = 24;
            double actualValue = triangle.TriArea(x, y, z);
            Assert.AreNotEqual(expectedValue, actualValue);
        }
    }
}
