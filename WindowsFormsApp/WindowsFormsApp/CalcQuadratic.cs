using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp
{
    class CalcQuadratic
    {
        public double[] CalcX(int a, int b, int c)
        {
            double d, x1, x2;
            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                double[] answer = { x1, x2 };
                return answer;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                double[] answer = { x1, x2 };
                return answer;
            }
            else
            {
                double[] answer = { 0, 0, 0 };
                return answer;
            }
        }
    }
}
