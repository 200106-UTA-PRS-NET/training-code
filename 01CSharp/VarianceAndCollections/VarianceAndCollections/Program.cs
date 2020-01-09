using System;
using System.Collections;// for non generics
using System.Collections.Generic; // generic collections

namespace VarianceAndCollections
{
    class Program
    {
        const float Pi = 3.14f;// value cannot be changed 
        readonly int gravity = 9;// value cannot be changed except in constructor
        static void Main(string[] args)
        {            

            # region variance
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
            #endregion
            #region Generics
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
            #endregion
            #region Arrays
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
            //Console.WriteLine(ReverseString("Fred"));
            //FizzBuzz(20);

            // Arrays types - 1 D arrays, 2 D arrays, Jagged arrays
            //2D Arrays
            int[,] twoDArray = new int[3,4];
            // Jagged Arrays- Array within an array
            int[][] jaggedArray = new int[3][];// initialize rows first
            // initialize columns for each row
            jaggedArray[0] = new int[4] {2,3,4,5 };// row 1 with array initializer synatx
            jaggedArray[1] = new int[2] {6,7 };// row 2
            jaggedArray[2] = new int[3] { 9,8,7};// row 3
            for (int i = 0; i < jaggedArray.Length; i++) // loops through all the rows
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) // loops through all the columns
                {
                    Console.Write(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region Collections
            // Collections
            // Arrays had drawbacks - 1. fixed sized, 2. inefficient utilization of memory
            // Collections in C# are of 2 types :
            // Non Generic collections - Old way of creating collection, Namespace-> System.Collections, all the items are in the form of Object
            // ArrayList (like Arrays), Stack (LIFO), Queue (FIFO), Hashtable (key value pair)
            ArrayList list1 = new ArrayList();
            // Add items to ArrayList
            list1.Add("Apple");
            list1.Add(100);
            list1.Add('a');
            Console.WriteLine("After Adding all the items");
            foreach (var listItem in list1)
            {
                Console.WriteLine(listItem);
            }
            Console.WriteLine("After Deleting items " );
            //  list1.Remove(100);
            list1.RemoveAt(2);// remove item from an index 
            foreach (var listItem in list1)
            {
                Console.WriteLine(listItem);
            }
            // Stack - Push(obj), Pop(), Peek() to read topmost item
            // Queue - Enqueue(obj), Dequeue

            // Generic Collections - System.Collection.Generics , Items are tyep specific
            // List<T>, Stack<T>, Queue<T>, Dictonery<TKey,TValue>
            // no overhead on GC, No boxing happening 

            //List<string> name = new List<string>();
            //name.Add("Fred");
            //name.Add("Nick");
            //name.Add("Carol");

            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee() { Id = 1, name = "Pushpinder" };// object initializer syntax
            Employee emp2 = new Employee() { Id = 2, name = "Nick" };
            employees.Add(emp1);
            employees.Add(emp2);

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id} {employee.name}" );
            }

            // Stack<T>
            Stack<string> stk = new Stack<string>();
            stk.Push("Apple");
            stk.Push("Grapes");

            // Dictionery - all keys have to be unique
            Dictionary<int, string> books = new Dictionary<int, string>();
            books.Add(23, "War and Peace");
            books.Add(12, "C# Programming");
            books.Add(34, "Angular");

            foreach (var bookKey in books.Keys)
            {
                Console.WriteLine($"{bookKey}  {books[bookKey]}");
            }
            #endregion
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
