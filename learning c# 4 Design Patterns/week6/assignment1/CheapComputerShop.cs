using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class CheapComputerShop : ComputerShop
    {
        public CheapComputerShop() { }
      
        public override IHardDisk CreateHardDisk()
        {
            return new CheapHardDisk();
        }

        public override IMonitor CreateMonitor()
        {
            return new CheapMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }
    }
}

