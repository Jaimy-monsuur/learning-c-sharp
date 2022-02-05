using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.Start();
        }
        void Start()
        {
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            Console.WriteLine();
            CheckValues(myStack);
            CheckValues(myStack);
            Console.WriteLine();
            ProcessValues(myStack);
            Console.ReadKey();
        }
        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = rnd.Next(1, 100);
                stack.Push(value);
                Console.WriteLine($"pushed {value,2}, new count: { stack.Count}");
            }
        }
        void CheckValues(IStack stack) 
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool contains = stack.Contains(number);
            if (contains == true)
            {
                Console.WriteLine($"stack contains value {number}");
            }
            else
            {
                Console.WriteLine($"stack does not contain value {number}");
            }
        }
        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value,2}, new count: {stack.Count}");
            }
        }
    }
}
