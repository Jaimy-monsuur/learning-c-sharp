using System;
using DAL;
using Model;
using _ReservationSystemLogic;
using System.Collections.Generic;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            BookService bookService = new BookService();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing CustomerService\n");
            Console.ResetColor();

            Console.Write("Enter customer id: ");
            int cusId = int.Parse(Console.ReadLine());
            Customer customer = customerService.GetById(cusId);
            Console.WriteLine(customer.ToString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\ntesting BookService\n");
            Console.ResetColor();

            Console.Write("Enter name of author: ");
            string name = Console.ReadLine();

            List<Book> books = bookService.GetByAuthor(name);
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
            

        }
    }
}
