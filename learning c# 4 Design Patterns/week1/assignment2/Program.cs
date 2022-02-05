using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Pencil pencil = new Pencil(20);
            PencilSharpener pencilSharpener = new PencilSharpener();
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            while (input.ToLower() != "stop")// to lower zodat het altijd stopt ook bij hoofdletters.
            {
                if (input.ToLower() == "sharpen")
                {
                    pencilSharpener.Sharpen(pencil);
                }
                else
                {
                    pencil.Write(input);
                }

                Console.Write("\nEnter a word: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("end of program...");
        }

    }
}
