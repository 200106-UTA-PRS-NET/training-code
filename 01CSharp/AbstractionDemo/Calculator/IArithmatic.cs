using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    // Interface is a contract shared by all the classes
    // interface can not have any implementation
    // interface can have only 4 members - methods, properties, indexers and events
    interface IArithmatic
    {
        double Add(params double[] num);
        double Divide(double num, double deno);
        double Subs(int a, int b);  

    }
    interface IMoreArithmatic
    {
        double Add(int a, int b);
        double Subs(int a, int b);
    }
}
