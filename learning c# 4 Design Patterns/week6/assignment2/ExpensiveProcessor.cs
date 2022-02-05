using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class CheapProcessor : IProcessor
    {        
        public void PreformOperation()
        {
            Console.WriteLine("performing operation not so quickly...");
        }
    }
}
