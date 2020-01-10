using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        // Debugging - using Step into F11 (jump inside the methods on the way, Step Over F10 (jump over the method), Step out Shift + F11 (get out of the method currently in) )
        static void Main(string[] args)// Main Thread is created - Thread 1
        {
            Console.WriteLine("Inside Main Method");
            MethodCall();
            Console.WriteLine("Main Method finished");
            Console.Read();// Holds the screen 
        }
        public async static void MethodCall()
        {
            Console.WriteLine("-----------Inside Method 2 - starting-------------");
            await Task.Run(new Action(LongMethod));// creates a new Thread -> thread 2
            Console.WriteLine("---------- Method 2 finished-----------");
        }

        public static void LongMethod()
        {
            Console.WriteLine("-------------  Starting Long Method----------");
            Thread.Sleep(6000);
            Console.WriteLine("--------------Long method finshed-----------");
        }
    }
}
