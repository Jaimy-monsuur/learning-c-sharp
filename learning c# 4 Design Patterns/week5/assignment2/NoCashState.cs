using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class NoCashState : IATMState
    {
        public ATMMachine machine;
        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void Enter_Pincode()
        {
            Console.WriteLine("No card present");
        }

        public void Insert_Card()
        {
            Console.WriteLine("Not enough cash available in machine");

        }

        public void Reject_Card()
        {
            Console.WriteLine("No card to reject");
        }

        public void Withdraw_Cash()
        {
            Console.WriteLine("Not enough cash available in machine");
        }
    }
}
