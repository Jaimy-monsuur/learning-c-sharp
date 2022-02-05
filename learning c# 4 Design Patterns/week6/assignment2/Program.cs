using System;

namespace assignment2
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
            // ... create factory
            IComputerFactory HighBudgetComputerFactory = new HighBudgetFactory();
            // ... create shop
            ComputerShop ExpensiceComputerShop = new ComputerShop(HighBudgetComputerFactory);
            // ... assemble (one) computer
            Computer c1 = ExpensiceComputerShop.AssembleComputer();
            // ... test the new computer
            c1.Test();
            Console.WriteLine();
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            // ... create factory
            IComputerFactory LowBudgetComputerFactory = new LowBudgetFactory();
            // ... create shop
            ComputerShop CheapComputerShop = new ComputerShop(LowBudgetComputerFactory);
            // ... assemble (one) computer
            Computer c2 = CheapComputerShop.AssembleComputer();
            // ... test the new computer
            c2.Test();
        }

    }
}
