using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public class Robot
    {
        public string Person { get; set; }

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }
        public void MoveByPerson(string person)
        {
            Console.WriteLine($"Robot is moved by {person}");
            this.Person = person;
        }
        public void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }
    }
}
