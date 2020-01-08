using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public abstract class Arithmatic
    {

        internal virtual double Add(params double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                 result += numbers[i];
            }
            return result;
        }
        internal abstract double Subs(double a, double b);
        internal abstract double Divide(double num, double deno);
    }
}
