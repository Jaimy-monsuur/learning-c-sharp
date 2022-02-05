using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NextSong();
    }
}
