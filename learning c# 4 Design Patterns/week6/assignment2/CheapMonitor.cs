using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("displaying stuff very nice...");
        }
    }
}
