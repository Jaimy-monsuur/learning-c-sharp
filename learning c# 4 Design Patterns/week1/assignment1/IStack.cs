using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public interface IStack
    {
        void Push(int value);// pushes a new item (int) onto the stack; throw an exception when the
        int Pop();/* returns the last pushed item (int) on the stack (and removes this item from the
                     stack); throw an exception if the stack is empty*/
        bool Contains(int value);// returns true if the stack contains a specific item (int), false otherwise
        int Count { get; }// returns the number of items on the stack
        bool IsEmpty { get; }//  returns true if the stack is empty, false otherwise

    }
}
