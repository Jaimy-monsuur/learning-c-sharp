using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()//void Start(string[] args) er uit gehaald
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Print();

            deck.Shuffle();
            deck.Print();

            Console.ReadLine();
        }
    }
}
