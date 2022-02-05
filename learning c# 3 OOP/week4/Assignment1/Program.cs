using System;
using Model;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book potter = new Book(001, "Harry Potter and the prisoner of Azkaban", "J.K. Rowling");
            Book davince = new Book(002, "The Da Vince Code", "Dan Brown");

            Customer lionel = new Customer(01, "Lionel", "Messi", "Lionelmessi@hotmail.com");
            Customer don = new Customer(02, "Don", "Henley", "donhenley@gmail.com");

            Reservation R1 = new Reservation(20, lionel, davince);
            Reservation R2 = new Reservation(21, don, davince);

            //TEST customers
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing custommers");
            Console.ResetColor();
            Console.WriteLine(lionel.ToString());
            Console.WriteLine(don.ToString());
            //TEST books
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\ntesting books");
            Console.ResetColor();
            Console.WriteLine(potter.ToString());
            Console.WriteLine(davince.ToString());
            //TEST reservations
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\ntesting reservation");
            Console.ResetColor();
            Console.WriteLine(R1.ToString());
            Console.WriteLine(R2.ToString());
        }
    }
}
