using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class ATMMachine
    {
        public int amountinMachine;
        private IATMState cardPresent;
        private IATMState corectPinCode;
        private IATMState noCard;
        private IATMState noCash;

        private IATMState CurrentState;
        public ATMMachine(int Monney)
        {
            SetAmountinMachine(Monney);
            this.cardPresent = new CardPresentState(this);
            this.corectPinCode = new CorrectPinState(this);
            this.noCard = new NoCardState(this);
            this.noCash = new NoCashState(this);

            if (amountinMachine > 0)
            {
                GetNoCardState();
            }
            else
            {
                GetNoCashState();
            }
        }
        public void EnterPinCode()
        {
            CurrentState.Enter_Pincode();
            Console.WriteLine();
        }
        public void InsertCard()
        {
            CurrentState.Insert_Card();
            Console.WriteLine();
        }
        public void RejectCard()
        {
            CurrentState.Reject_Card();
            Console.WriteLine();
        }
        public void WithdrawCash()
        {
            CurrentState.Withdraw_Cash();
            Console.WriteLine();
        }
        private void SetMachineState(IATMState state)
        {
            this.CurrentState = state;
        }
        public void SetAmountinMachine(int Monney)
        {
            this.amountinMachine = Monney;
        }
        public void GetCardPresentState()
        {
            SetMachineState(cardPresent);
        }
        public void GetCorrectPinState()
        {
            SetMachineState(corectPinCode);
        }
        public void GetNoCardState()
        {
            SetMachineState(noCard);
        }
        public void GetNoCashState()
        {
            SetMachineState(noCash);
        }
    }
}
