using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class ExpensiveProcessor : IProcessor
    {        
        public void PreformOperation()
        {
            Console.WriteLine("performing operation very quickly...");
        }
    }
}
