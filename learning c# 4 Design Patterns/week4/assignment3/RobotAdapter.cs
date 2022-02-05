using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public class RobotAdapter : IAttacker
    {
        public string Driver { get { return robot.Person; } set { Driver = robot.Person; } }

        public Robot robot;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver(string name)
        {
            robot.MoveByPerson(name);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
