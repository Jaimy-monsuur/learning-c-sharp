using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class LowBudgetFactory : IComputerFactory
    {
        public LowBudgetFactory() { }
        public IHardDisk CreateHardDisk()
        {
            return new CheapHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new CheapMonitor();
        }

        public IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }
    }
}

