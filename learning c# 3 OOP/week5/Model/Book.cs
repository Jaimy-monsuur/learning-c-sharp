using System;

namespace Model
{
    public class Book
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Author { get; set; }
        public string Title { get; set; }

        public Book(int id, string title, string author)
        {
            this.Id = id;
            this.Author = author;
            this.Title = title;
        
        }

        public override string ToString()
        {
            return $"'{Title}' by {Author}";
        }
    }
}
