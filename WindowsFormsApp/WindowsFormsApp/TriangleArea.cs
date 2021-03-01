using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp
{
    public class TriangleArea
    {
        public double TriArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
