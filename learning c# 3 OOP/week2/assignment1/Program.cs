using System;
using System.Globalization;
using System.Threading;


namespace assignment1
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
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            // your code here...
            Bookstore store = new Bookstore();

            Book Dracula = new Book("Dracula", "Bram Stoker", 15.00);
            Book Joe = new Book("Joe speedboot", "Tommy Wieringa", 12.50);
            Book Hobbit = new Book("The hobbit", "J.R.R. Tolkien", 12.50);

            Magazine Time = new Magazine("Time", "Friday", 3.90);
            Magazine DonaldDuck = new Magazine("Donald Duck", "Thursday", 2.50);


            store.Add(Dracula);
            store.Add(Joe);
            store.Add(Time);
            store.Add(DonaldDuck);
            store.Add(Hobbit);

            store.PrintCompleteStock();

        }
    }
}
