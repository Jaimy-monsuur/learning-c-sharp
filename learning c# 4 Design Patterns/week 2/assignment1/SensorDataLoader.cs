using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class SensorDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting sensor data...");
        }
        public override void Transform()
        {
            Console.WriteLine("transforming sensor data...");
        }
    }
}
