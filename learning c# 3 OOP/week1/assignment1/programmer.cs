using System;
using System.Collections.Generic;
using System.Text;

namespace asignment1
{
    class programmer
    {
        public string name;
        public Specialty member;

        public programmer(string name)
        {
            this.name = name;
            this.member = Specialty.Unknown;
        }
        public programmer(string name, Specialty member)
            : this(name)
        {
            this.member = member;
        }

        public void print()
        {
            Console.WriteLine($"Name: {this.name}, Specialty: {this.member}");
        }
    }
}
