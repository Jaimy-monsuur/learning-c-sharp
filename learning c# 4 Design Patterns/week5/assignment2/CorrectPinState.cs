using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class CorrectPinState : IATMState
    {
        public ATMMachine machine;
        public CorrectPinState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void Enter_Pincode()
        {
            Console.WriteLine("Pincode has already been entered");
        }

        public void Insert_Card()
        {
            Console.WriteLine("A card has been inserted already");
        }

        public void Reject_Card()
        {
            Console.WriteLine("Your card has been rejected");
            machine.GetNoCardState();
        }

        public void Withdraw_Cash()
        {
            Console.Write("Please enter amout of cash: ");
            int amount = int.Parse(Console.ReadLine());
            if (machine.amountinMachine - amount >= 0)
            {
                machine.SetAmountinMachine(machine.amountinMachine - amount);
                Console.WriteLine($"{amount} withdrawn from machine");
                Reject_Card();
            }
            else
            {
                Console.WriteLine("Not enough cash available in machine");
                Reject_Card();
                machine.GetNoCashState();
            }
        }
    }
}
