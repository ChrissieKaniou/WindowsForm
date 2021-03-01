using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WindowsFormsApp
{
    [TestFixture]
    public class CalcQuadraticTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalcXTest()
        {
            CalcQuadratic quadratic = new CalcQuadratic();
            int x = 1;
            int y = -3;
            int z = -4;
            double[] expectedValue = { 4.0d, -1.0d };
            double[] actualValue = quadratic.CalcX(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void CalcXTest2()
        {
            CalcQuadratic quadratic = new CalcQuadratic();
            int x = -1;
            int y = 3;
            int z = 4;
            double[] expectedValue = { 4.0d, -1.0d };
            double[] actualValue = quadratic.CalcX(x, y, z);
            Assert.AreNotEqual(expectedValue, actualValue);
        }
    }
}
