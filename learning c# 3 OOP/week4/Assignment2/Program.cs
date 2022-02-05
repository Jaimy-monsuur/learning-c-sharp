using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            BookDAO bookDAO = new BookDAO();

            // display all customers
            List<Customer> customers = customerDAO.GetAll_Customers();
            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust.ToString()); ;
            }

            Console.Write("\nEnter customer id: ");
            int custid = int.Parse(Console.ReadLine());
            // display a specific customer
            Customer customer = customerDAO.GetCustomer_Byld(custid);
            if (customer != null)
            {
                Console.WriteLine(customer.ToString()); ;
            }
            else
            {
                Console.WriteLine("No customer with id: " + custid);
            }

            Console.WriteLine();

            // display all books
            List<Book> books = bookDAO.GetAll_Books();
            foreach (Book b in books)
            {
                Console.WriteLine(b.ToString()); ;
            }

            Console.Write("\nEnter book id: ");
            int bookid = int.Parse(Console.ReadLine());
            // display a specific book
            Book book = bookDAO.GetBook_Byld(bookid);
            if (customer != null)
            {
                Console.WriteLine(book.ToString()); ;
            }
            else
            {
                Console.WriteLine("No customer with id: " + bookid);
            }
            Console.ReadKey();
        }
    }
}
