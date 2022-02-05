using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class ExpensiveComputerShop : ComputerShop
    {
        public ExpensiveComputerShop() { }
        public override IHardDisk CreateHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public override IMonitor CreateMonitor()
        {
            return new ExpensiveMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}
