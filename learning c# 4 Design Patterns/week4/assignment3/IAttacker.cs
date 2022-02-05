using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    interface IAttacker
    {
        public string Driver { get; set; }

        public void AssignDriver(string name);
        public void DriveForward();
        public void UseWeapon();

    }
}
