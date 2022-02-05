using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class HighBudgetFactory : IComputerFactory
    {
        public HighBudgetFactory() { }
        public IHardDisk CreateHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new ExpensiveMonitor();
        }

        public IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}

