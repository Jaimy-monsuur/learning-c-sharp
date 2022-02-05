using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public interface ITrainJourney
    {
        public void Next_Train();
        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
    }
}
