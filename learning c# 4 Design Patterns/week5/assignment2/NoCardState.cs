using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class NoCardState : IATMState
    {
        public ATMMachine machine;
        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void Enter_Pincode()
        {
            Console.WriteLine("Please insert a card first");
        }

        public void Insert_Card()
        {
            Console.WriteLine("Card has been inserted");
            //naar card present
            machine.GetCardPresentState();
        }

        public void Reject_Card()
        {
            Console.WriteLine("No card to reject");
        }

        public void Withdraw_Cash()
        {
            Console.WriteLine("Please insert a card first");
        }
    }
}
