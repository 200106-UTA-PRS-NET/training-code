using Microsoft.Extensions.Logging;
using System;
using System.IO;// file input output operation

namespace Exceptions
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     //ILogger
        //     string path = "C:/Revature/Test.txt";
        //     StreamReader stream=null;
        //// doagain:
        //     try {
        //         stream = new StreamReader(path);
        //         Console.WriteLine(stream.ReadToEnd());
        //     }
        //     catch(FileNotFoundException ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //        //crazy trials
        //         /* File.Create(path);
        //         //log 
        //         goto doagain;*/
        //     }
        //     catch(DirectoryNotFoundException ex)
        //     {
        //         Console.WriteLine(ex.StackTrace);
        //         File.Create(path);
        //         //log 
        //         //goto doagain;
        //     }
        //     finally
        //     {
        //         if (stream !=null)
        //         {
        //             stream.Close();
        //         }
        //     }
        //     Console.Read();
        // }
        /// <summary>
        /// ----- Understanding throw vs rethrow ---------
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                DoSomeUsefulWork();
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }

        private static void DoSomeUsefulWork()
        {
            try
            {
                ICanThrowException();
                ICanThrowException();
            }
            catch (Exception ex)
            {
                Log(ex);
                throw;
            }
        }
        private static void ICanThrowException()
        {
            throw new Exception("Bad thing happened");
        }

        private static void Log(Exception ex)
        {
            // Intentionally left blank
        }
    }
}
