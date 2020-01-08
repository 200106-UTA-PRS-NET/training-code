using System;

namespace VarianceAndCollections
{
    class Program
    {

        static void Main(string[] args)
        {
            ///Type Conversion
            double x = 100;
            int y = (int)x;// explicit type casting -> data loss
            int z = 23;
            x = z; //implict type casting -> there is no data loss


            /// Boxing (value type is converted to Reference type) and unboxing  (reference type converted to a value type)
            // boxing 
            int a = 10;
            string b = a.ToString();// boxing
            int c = Convert.ToInt32("100");// unboxing -> data loss

            /// Upcasting and downcasting
            object o = a;// upcasting -> implict  
            object p = "100";
            int q =Convert.ToInt32(p);// downcasting -> explict

            // Call Generic class 
            TestGenerics<string> testGenerics = new TestGenerics<string>();
            Console.WriteLine(testGenerics.Add("Hello World"));
            string s1 = "Hello";
            string s2 = s1;
            Console.WriteLine(testGenerics.TestEquals(s1,s2));

            int a1 = 10;
            int b1 = a;
            TestGenerics<int> testGenerics2 = new TestGenerics<int>();
            Console.WriteLine( testGenerics2.TestEquals(a1,b1));
            TestGenerics<DateTime> testGenerics1 = new TestGenerics<DateTime>();
            Console.WriteLine(testGenerics1.Add(DateTime.Now));
            Console.WriteLine( testGenerics1.TestEquals(DateTime.Now, DateTime.Now));

            // Arrays - homogeneous   collection of items placed in contigious memory locations
            // 1. declare an array
            int[] marks;
            //2.  initialize the array
                    // size of the array
            marks = new int[10];
            // adding values to the array
            //marks[0] = 56;
            //marks[1] = 78;
            Console.WriteLine("enter all 10 marks ");
            for (int i = 0; i < marks.Length; i++)
            {
               // marks[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reading marks " );
            // to display array items 
            foreach (int mark in marks)
            {
                //Console.WriteLine(mark);
            }
            Console.WriteLine(ReverseString("Fred"));
            FizzBuzz(20);
        }

        // w.a.p to reverse a string without using Reverse method
       static internal string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }
        // w.a.p for fizzbuzz game
        static internal void FizzBuzz(int num)
        {
            int fizzez=0;
            int buzzez=0;
            int fizzbuzzes = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzzes++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizzez++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzzez++;
                }
                else
                {
                    Console.WriteLine(i);
                }                
            }
            Console.WriteLine("Fizzes {0}", fizzez);
            Console.WriteLine("Buzzez {0}", buzzez);
            Console.WriteLine("Fizzbuzzes {0}", fizzbuzzes);
        }
    }
}
