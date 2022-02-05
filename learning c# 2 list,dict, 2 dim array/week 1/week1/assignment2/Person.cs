using System;
using System.Collections.Generic;
using System.Text;

namespace assignent2
{
    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string City;
        public GenderType Gender;
    }

    public enum GenderType
    {
        m, f
    }
}

