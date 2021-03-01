using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WindowsFormsApp
{
    [TestFixture]
    public class CalcPolynomialTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void solveTest()
        {
            CalcPolynomial polynomial = new CalcPolynomial();
            double[] a = { 0, -12, 0, 3 };
            String[] expectedValue = { "2", "-2" };
            String[] actualValue = polynomial.solve(a);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void solveTest2()
        {
            CalcPolynomial polynomial = new CalcPolynomial();
            double[] a = { 1, 2, 3, 4 };
            String[] expectedValue = { "2", "-2" };
            String[] actualValue = polynomial.solve(a);
            Assert.AreNotEqual(expectedValue, actualValue);
        }
    }
}
