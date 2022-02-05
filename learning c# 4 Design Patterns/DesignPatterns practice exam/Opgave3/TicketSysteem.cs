using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave3
{
    public class TicketSysteem
    {
        private static TicketSysteem _TicketSysteem;
        public Dictionary<string, int> tickets;
        private TicketSysteem()
        {
            tickets = new Dictionary<string, int>();
            tickets.Add("Bruno Mars", 250);
            tickets.Add("Coldplay", 175);
            tickets.Add("Ed Sheeran", 150);
        }
        public static TicketSysteem getInstance()
        {
            if (_TicketSysteem is null)
            {
                _TicketSysteem = new TicketSysteem();
            }
            return _TicketSysteem;
        }
        public void PrintOverzicht()
        {
            foreach (KeyValuePair< string, int> t in tickets)
            {
                Console.WriteLine($"artiest: {t.Key}, aantal tickets: {t.Value}");
            }
        }
        public void VerkoopTickets(string artiest, int aantal)
        {
            if (tickets.ContainsKey(artiest))
            {
                if (tickets[artiest] - aantal >= 0)
                {
                    tickets[artiest] = tickets[artiest] - aantal;
                }
            }
            else
            {
                throw new Exception($"There are not tickets for artist: {artiest}");
            }
        }
    }
}
