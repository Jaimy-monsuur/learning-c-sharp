using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public abstract class ComputerShop
    {
        public Computer AssembleComputer()
        {
            Computer c = new Computer();
            c.processor = CreateProcessor();
            c.hardDisk = CreateHardDisk();
            c.monitor = CreateMonitor();
            return c;
        }

        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHardDisk();
        public abstract IMonitor CreateMonitor();

    }
}
