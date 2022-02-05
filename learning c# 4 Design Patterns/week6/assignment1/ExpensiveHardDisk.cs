using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data very quickly...");
        }
    }
}
