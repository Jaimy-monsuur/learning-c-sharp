using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            // ... create shop
            ComputerShop ExpensiveComputerShop = new ExpensiveComputerShop();
            // ... assemble (one) computer
            Computer c1 = ExpensiveComputerShop.AssembleComputer();
            // ... test the new computer
            c1.Test();
            Console.WriteLine();
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            // ... create shop
            ComputerShop CheapComputerShop = new CheapComputerShop();
            // ... assemble (one) computer
            Computer c2 = CheapComputerShop.AssembleComputer();
            // ... test the new computer
            c2.Test();
        }

    }
}
