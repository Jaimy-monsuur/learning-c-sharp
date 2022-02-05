using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        private void Start()
        {
            PrintHeader("MacBook");
            Laptop macBook = new MacBook("S/N A1287");
            macBook.Execute("virusscanner.exe");

            PrintHeader("HP");
            Laptop hp = new HPLaptop("S/N 893419");
            hp.Execute("virusscanner.exe");

            PrintHeader("changed MacBook");
            // wijzig macBook hier... (TODO)
            macBook.Processor = new Intel_i7();
            macBook.Execute("virusscanner.exe");
        }

        private void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
