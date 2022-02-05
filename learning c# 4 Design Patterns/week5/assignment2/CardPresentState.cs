using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class CardPresentState : IATMState
    {
        public ATMMachine machine;
        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void Enter_Pincode()
        {
            Console.Write("Please enter your pincode: ");
            string input = Console.ReadLine();
            if (input == "1234")
            {
                Console.WriteLine("You have entered the correct pincode");
                machine.GetCorrectPinState();
            }
            else
            {
                Console.WriteLine("Wrong Pincode");
            }          
        }

        public void Insert_Card()
        {
            Console.WriteLine("A card has been inserted already");
        }

        public void Reject_Card()
        {
            Console.WriteLine("Your card has been rejected");
            //terug naar nocard
            machine.GetNoCardState();
        }

        public void Withdraw_Cash()
        {
            Console.WriteLine("Enter pincode first");
        }
    }
}
