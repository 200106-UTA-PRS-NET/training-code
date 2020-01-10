using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    partial class Miscellaneous
    {
        // logic for UI
    }
    partial class Miscellaneous
    {
        // logic gor handling data

        //partial methods can also be splitted just like partial classes
    }
    // sealed classes can not be inherited 
    class GrandParent
    {
        public virtual void Test()
        {
            Console.WriteLine("inside grandparent");
        }
    }
    sealed class NonParent:GrandParent
    {
        public new void Test()
        {

        }
        // sealed methods can't be overriden
    }
    class Parent: GrandParent{

        public  override void Test()
        {
            Console.WriteLine("Inside sealed method in Parent ");
        }
        protected void DoSomething()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent//NonParent
    {

        public override void Test()
        {
            Console.WriteLine("Inside grand child");
        }
        public new void DoSomething()
        {
            Console.WriteLine("Child class");
        }
    }
}
