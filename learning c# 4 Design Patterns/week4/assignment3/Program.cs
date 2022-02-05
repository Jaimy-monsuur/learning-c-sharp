using System;
using System.Collections.Generic;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            // create a tank (and assign a driver)
            IAttacker tank = new Tank();
            tank.AssignDriver("Frank");

            // create a robot
            IAttacker robot = new RobotAdapter(new Robot());
            robot.AssignDriver("Mark");
            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(robot);
            Console.WriteLine();
            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine($"Driver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }
        }
    }
}
