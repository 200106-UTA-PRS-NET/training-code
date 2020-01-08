using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            IArithmatic arithmatic = new Mathematics();// upcasting
            IMoreArithmatic moreArithmatic = new Mathematics();// upcasting
            Console.WriteLine($"Substraction result  { arithmatic.Subs(45, 6)}");
            Console.WriteLine($"Substraction more result  { moreArithmatic.Subs(45, 6)}");
            Console.WriteLine($"Addition result {m.Add(12, 23, 25, 56)}");
                                                    // Named parameters
            Console.WriteLine($"Division result {m.Divide(deno:9, num:36)}" );
        }
    }
}
