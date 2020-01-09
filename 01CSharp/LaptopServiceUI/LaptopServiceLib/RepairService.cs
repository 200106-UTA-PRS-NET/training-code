﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LaptopServiceLib
{
    // create a delegate
   public delegate void NotifyDel(); // delegate NotifyDel will be instantiated in the Main() -> [LaptopServiceUI project]
   public class RepairService
    {
        public void Repair(Laptop laptop)
        {
            Console.WriteLine("Repairing.......");

            Thread.Sleep(3000);
        }
    }
}
