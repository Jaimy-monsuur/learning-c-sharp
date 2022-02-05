using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class CheapHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data not so quickly...");
        }
    }
}
