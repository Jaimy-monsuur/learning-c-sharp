using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Book : StoreItem
    {
        public string Author { get; private set; }


        public Book(string title,string author, double price, int count)
            : base(title, price, count)
        {
            this.Author = author;
        }

        public override void Print()
        {
            Console.WriteLine($"[Book] '{Title}' by {Author}, {Price:0.00} ({Count}x)");
        }
    }
}
