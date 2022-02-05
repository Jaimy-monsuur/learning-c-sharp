using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class ComputerShop
    {
        private IComputerFactory factory;
        public ComputerShop(IComputerFactory factory)
        {
            this.factory = factory;
        }

        public Computer AssembleComputer()
        {
            Computer c = new Computer();
            c.processor = factory.CreateProcessor();
            c.hardDisk = factory.CreateHardDisk();
            c.monitor = factory.CreateMonitor();
            return c;
        }

    }
}
