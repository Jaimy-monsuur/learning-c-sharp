using System;

namespace Opgave3
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
            TicketSysteem ticketSysteem1 = TicketSysteem.getInstance();
            TicketSysteem ticketSysteem2 = TicketSysteem.getInstance();

            PrintHeader("ticket overzicht (printed with ticketSysteem1)");
            ticketSysteem1.PrintOverzicht();
            ticketSysteem1.VerkoopTickets("Bruno Mars", 50);
            PrintHeader("nieuw ticket overzicht (printed with ticketSysteem1)");
            ticketSysteem1.PrintOverzicht();

            ticketSysteem2.VerkoopTickets("Ed Sheeran", 100);
            PrintHeader("nieuw ticket overzicht (printed with ticketSysteem2)");
            ticketSysteem2.PrintOverzicht();

        }
        private void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
