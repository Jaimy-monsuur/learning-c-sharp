using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        public void start()
        {
            ATMMachine machine = new ATMMachine(2000);

            Console.Write("Please enter your command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string command = Console.ReadLine();
            Console.ResetColor();
            while (command.ToLower() != "stop")
            {
                if (command =="insert card")
                {
                    machine.InsertCard();
                }
                else if (command == "reject card")
                {
                    machine.RejectCard();
                }
                else if (command == "enter pincode")
                {
                    machine.EnterPinCode();
                }
                else if (command == "withdraw cash")
                {
                    machine.WithdrawCash();
                }
                else
                {
                    Console.WriteLine("entered unknown command\n");
                }
                //end of loop
                Console.Write("Please enter your command: ");
                Console.ForegroundColor = ConsoleColor.Green;
                command = Console.ReadLine();
                Console.ResetColor();
            }
        }
    }
}
