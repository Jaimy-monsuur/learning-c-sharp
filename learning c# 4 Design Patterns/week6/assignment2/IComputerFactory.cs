using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public interface IComputerFactory
    {
        public IProcessor CreateProcessor();
        public IHardDisk CreateHardDisk();
        public IMonitor CreateMonitor();
    }
}
