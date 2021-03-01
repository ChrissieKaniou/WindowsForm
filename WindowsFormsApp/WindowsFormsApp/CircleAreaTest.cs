using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WindowsFormsApp
{
    [TestFixture]
    public class CircleAreaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CirAreaTest()
        {
            CircleArea circle = new CircleArea();
            double x = 1;
            double expectedValue = 3.1415926535897931d;
            double actualValue = circle.CirArea(x);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void CirAreaTest2()
        {
            CircleArea circle = new CircleArea();
            double x = 2;
            double expectedValue = 3.1415926535897931d;
            double actualValue = circle.CirArea(x);
            Assert.AreNotEqual(expectedValue, actualValue);
        }
    }
}
