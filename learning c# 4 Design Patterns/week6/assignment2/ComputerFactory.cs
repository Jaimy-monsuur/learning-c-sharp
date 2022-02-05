using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public abstract class ComputerFactory
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
