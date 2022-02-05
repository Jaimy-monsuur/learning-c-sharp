using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {
            int Value = LeesInt("Enter a value: ");
            Console.WriteLine("you entered {0}.", Value);

            int Age = LeesInt("How old are you? ", 0, 120);
            Console.WriteLine("You are {0} years old.", Age);

            int Age = LeesInt("How old are you? ", 0, 120);
            Console.WriteLine("You are {0} years old.", Age);

            string Name = LeesNaam("What is your name? ");
            Console.WriteLine("Nice meeting you {0}.", Name);

        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);
            int Value = int.Parse(Console.ReadLine());
            return Value;
        }

        int LeesInt(string vraag, int min, int max)
        {
            Console.Write(vraag);
            int Age = int.Parse(Console.ReadLine());
            return Age;
        }

        string LeesNaam(string vraag)
        {
            Console.Write(vraag);
            string Name = Console.ReadLine();
            return Name;
        }


    }
}
