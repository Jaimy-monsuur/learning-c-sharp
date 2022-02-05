using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public interface IATMState
    {
        public void Insert_Card();
        public void Enter_Pincode();
        public void Reject_Card();
        public void Withdraw_Cash();

    }
}
