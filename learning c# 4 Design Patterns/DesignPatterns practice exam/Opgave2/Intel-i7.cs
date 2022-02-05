using System;

namespace Opgave2
{
    public class Intel_i7 : IProcessor
    {
        public void Execute(string programName)
        {
            Console.WriteLine($"Executing program  '{programName}' with processor Intel i7");
        }
    }
}
