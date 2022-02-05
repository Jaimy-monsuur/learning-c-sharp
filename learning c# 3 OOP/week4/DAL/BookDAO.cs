using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BookDAO
    {
        private SqlConnection dbConnection;
        public BookDAO()
        {
            string connString = ConfigurationManager
                                                 .ConnectionStrings["DBConnectionString"]
                                                 .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Book> GetAll_Books()
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Books", dbConnection);

            SqlDataReader reader = command.ExecuteReader();
            List<Book> Books = new List<Book>();
            while (reader.Read())
            {
                Book book = ReadBook(reader);
                Books.Add(book);
            }


            //reader.Close();
            dbConnection.Close();

            return Books;
        }

        public Book GetBook_Byld(int Bookid)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
             "SELECT * FROM Books WHERE Id = @Id", dbConnection);

            command.Parameters.AddWithValue("@Id", Bookid);

            SqlDataReader reader = command.ExecuteReader();
            Book book = null;
            if (reader.Read())
            {
                book = ReadBook(reader);
            }
            reader.Close();
            dbConnection.Close();

            return book;
        }

        private Book ReadBook(SqlDataReader reader)
        { // retrieve data from all fields
            int id = (int)reader["Id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];

            // return new Customer object
            return new Book(id, title, author);
        }
    }

}
