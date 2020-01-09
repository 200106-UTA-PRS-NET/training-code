using System;
using LaptopServiceLib;

namespace LaptopServiceUI
{
    class Program
    {
        static double CircleArea(double radius)
        {
            return radius * radius;
        }
        static void Main(string[] args)
        {
            // instantiate the delegate
            //         vvv
            // Target Method tied to the delegate
            //NotifyDel notifyDel = new NotifyDel(EmailService.SendEmail);
            Action notifyDel = new Action(EmailService.SendEmail);

            // C# offers predefined delegates like Action(delegate of type void), func(delegate that have a return type)

            // Types of Delegates:
            //      Single cast delegate - a delegate which is tied to a method
            //      Multicast delegate - a delegate tied to more than one method
            notifyDel += TextService.SendText; // subscribing the methods to make multicast delegate
            // delegates maintains an invocation list that contains reference to all subscribed methods                                    
            // Invoke the delegate
            //  notifyDel();
            notifyDel.Invoke();

            Console.WriteLine("----------Using Func Delegate------------");
            //     vvv    vvv
       //input parameter ,Return value
            Func<double,double> area = new Func<double,double>(CircleArea);
            Console.WriteLine($"Area of circle is { area.Invoke(4.5)}");

        }
    }
}
