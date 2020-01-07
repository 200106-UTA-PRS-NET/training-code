// Comments - Single Line Comment
/*
Multi-
Line
Comments
*/
//1. Namespace- is logical separation of the programs/code
//1.1 Predefined Namespace- using brings the existing lib into the current program
using System;

//1.2  Custom Namespace
namespace _01CSharp
{
    //1. Types - Primitive types (int, string, char), Value types, Reference types
    // Types can be - struct, class, interface, delegate, enums
     class Program
    {
        // 3. Type has Type members (variables/fields, methods, properties, events, indexers....)
        // C# Conventions -class, methods => ProperCase, variables=> camelCase
        static void Main(string[] args)// Entry point
        {
            string name;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();// to take input from user in strig form
            //Console.WriteLine("Welcome {0} to Revature",name);
            Console.WriteLine($"Welcome {name} to Revature");//string extrapolation with string literal
        }
    }
}
