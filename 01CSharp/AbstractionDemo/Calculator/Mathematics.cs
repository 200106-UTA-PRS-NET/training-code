using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    //class Mathematics : Arithmatic// implement abstract class 
    class Mathematics:IArithmatic,IMoreArithmatic// implementation of interfaces
    {
        public double Add(params double[] num)
        {
            double result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result += num[i];
            }
            return result;
        }

        public double Add(int a, int b)
        {
            return a + b;
        }

        // optional parameter
        public double Divide(double num, double deno=1)
        {
            return num / deno;
        }

        double IArithmatic.Subs(int a, int b)
        {
            return a - b;
        }

        double IMoreArithmatic.Subs(int a, int b)
        {
            return a * b;
        }


        //internal override double Subs(double a, double b)
        //{
        //    return a - b;
        //}
    }
}
