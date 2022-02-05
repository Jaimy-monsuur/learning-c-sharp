using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2
{
    public class AMD_Ryzen_3 : IProcessor
    {
        public void Execute(string programName)
        {
            Console.WriteLine($"Executing program  '{programName}' with processor AMD Ryzen 3");
        }
    }
}
