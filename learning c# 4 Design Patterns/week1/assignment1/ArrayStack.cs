using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment1
{
    class ArrayStack : IStack
    {
        private int count;
        public int Count 
        { 
            get 
            {
                return count;
            } 
        }

        public bool IsEmpty
        {
            get
            {
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            } 
        }

        public int[] stack;

        public ArrayStack(int stackSize)
        {
            stack = new int[stackSize];
        }

        public bool Contains(int value)
        {
            bool contains = false;
            for (int i = 0; i < stack.Length; i++)
            {
                if (stack[i] == value)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        public int Pop()
        {
            try
            {
                count--;
                int temp = stack[count];
                stack[count] = default;
                return temp;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ResetColor();
                throw;
            }
        }

        public void Push(int value)
        {
            try
            {
                stack[count] = value;
                count++;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ResetColor();
            }
        }
    }
}
