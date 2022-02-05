using System;

namespace opdracht3
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
            KopieerMachine machine1 = KopieerMachine.getInstance();
            KopieerMachine machine2 = KopieerMachine.getInstance();

            Console.WriteLine("kopieren met de 'machine 1'");
            machine1.Kopieer(10);
            machine1.Kopieer(23);
            Console.WriteLine();
            Console.WriteLine("kopieren met de 'machine 2'");
            machine2.Kopieer(40);
        }
    }
}
