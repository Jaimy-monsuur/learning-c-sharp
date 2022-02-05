using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;

namespace _ReservationSystemLogic
{
    public class BookService
    {
        BookDAO BookDAO = new BookDAO();
        public List<Book> GetAll()
        {

            List<Book> books = BookDAO.GetAll_Books();

            return books;
        }

        public Book GetById(int Bookid)
        {
            Book book = null;
            book = BookDAO.GetBook_Byld(Bookid);
            return book;
        }

        public List<Book> GetByAuthor(string authorName)
        {

            List<Book> books = BookDAO.GetByAuthor(authorName);

            return books;
        }
    }
}
