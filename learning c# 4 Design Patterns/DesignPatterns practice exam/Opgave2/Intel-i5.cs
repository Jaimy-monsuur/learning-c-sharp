using System;

namespace Opgave2
{
    class Intel_i5 : IProcessor
    {
        public void Execute(string programName)
        {
            Console.WriteLine($"Executing program  '{programName}' with processor Intel i5");
        }
    }
}
