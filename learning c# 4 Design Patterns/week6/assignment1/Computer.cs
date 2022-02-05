using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class Computer
    {
        public IProcessor processor;
        public IHardDisk hardDisk;
        public IMonitor monitor;
        public Computer()
        {

        }
        public void Test()
        {
            processor.PreformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }
    }
}
