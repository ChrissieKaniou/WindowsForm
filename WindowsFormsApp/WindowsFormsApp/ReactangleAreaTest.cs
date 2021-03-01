using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WindowsFormsApp
{
    [TestFixture]
    public class ReactangleAreaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RectAreaTest()
        {
            RectangleArea rectangle = new RectangleArea();
            int x = 4;
            int y = 5;
            int expectedValue = 20;
            int actualValue = rectangle.RectArea(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void RectAreaTest2()
        {
            RectangleArea rectangle = new RectangleArea();
            int x = 4;
            int y = 3;
            int expectedValue = 20;
            int actualValue = rectangle.RectArea(x, y);
            Assert.AreNotEqual(expectedValue, actualValue);
        }
    }
}
