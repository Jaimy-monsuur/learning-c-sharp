using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Customer
    {
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { if (value < DateTime.Today ) {dateOfBirth = value; }}
        }

        public int Age
        {
            get { int temp = DateTime.Now.Year - DateOfBirth.Year ;
                if (DateTime.Now.Month < dateOfBirth.Month || (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
                {
                    temp -= 1;
                }
                return temp;
            } 
        }

        public bool Discount
        {
            get
            {
                if (Age >= 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set {if (value != "") { name = value; }}
        }
        public Customer(string name, string date_of_birth)
        {
            this.DateOfBirth = DateTime.Parse(date_of_birth);
            this.Name = name;
        }
    }
}
