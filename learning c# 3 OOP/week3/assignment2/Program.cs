using System;
using System.Globalization;
using System.Threading;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-GB");// is opdracht moes ik us gebruiken maar dan is de datum verkeerd MM/DD/YY ipv DD/MM/YY
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            // your code here...

            Customer messi = new Customer("Lionel Messi", "24 June 1987");
            Customer piet = new Customer("Piet Paulusma", "15 December 1956");
            PrintCustomer(messi);
            PrintCustomer(piet);

            Reservation cus1 = new Reservation(messi);
            Reservation cus2 = new Reservation(piet);

            PrintReservation(cus1);
            PrintReservation(cus2);
        }

        void PrintCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(customer.Name);
            Console.ResetColor();
            Console.WriteLine("date of birth: " + customer.DateOfBirth.ToShortDateString() + "\nage: " + customer.Age);
            if (customer.Discount == true)
            {
                Console.WriteLine("discount: yes\n");
            }
            else
            {
                Console.WriteLine("discount: no\n");
            }
        }

        void PrintReservation(Reservation r)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"creating tickets (for {r.Customer.Name})");
            Console.ResetColor();
            foreach (Ticket t in r.Tickets)
            {
                Console.WriteLine(r.ToString(t));
            }
            Console.WriteLine($"total price of reservation: {r.TotalPrice:0.00}\n");
        }
    }
}
    

