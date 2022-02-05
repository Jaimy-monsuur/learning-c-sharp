using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class CheapProcessor : IProcessor
    {        
        public void PreformOperation()
        {
            Console.WriteLine("performing operation not so quickly...");
        }
    }
}
