using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public class Tank : IAttacker
    {
        public string Driver { get; set; }

        public void AssignDriver(string name)
        {
            Console.WriteLine($"{name} is steering the tank");
            this.Driver = name;
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage with weapon");
        }
    }
}
