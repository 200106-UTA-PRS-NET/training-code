using System;
using LaptopServiceLib;

namespace LaptopServiceUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the delegate
                                           //         vvv
                                           // Target Method tied to the delegate
            NotifyDel notifyDel = new NotifyDel(EmailService.SendEmail);

            // Types of Delegates:
            //      Single cast delegate - a delegate which is tied to a method
            //      Multicast delegate - a delegate tied to more than one method
            notifyDel += TextService.SendText; // subscribing the methods to make multicast delegate
            // delegates maintains an invocation list that contains reference to all subscribed methods                                    
            // Invoke the delegate
            //  notifyDel();
            notifyDel.Invoke();

        }
    }
}
