using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class DeckOfCards
    {
        public List<PlayingCard> deck = new List<PlayingCard>();
        public DeckOfCards()
        {
            InitCards();
        }

        void InitCards()
        {
            CardSuit suit = CardSuit.Spades;
            for (int i = 0; i < 4; i++)
            {
                if (i == 1)
                {
                    suit = CardSuit.Clubs;
                }
                else if (i == 2)
                {
                    suit = CardSuit.Hearts;
                }
                else if (i == 3)
                {
                    suit = CardSuit.Diamonds;
                }
                for (int j = 2; j < 15; j++)
                {
                    PlayingCard card = new PlayingCard(suit, j);
                    deck.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int Number1;
            int Number2;
            PlayingCard temp;

            for (int i = 0; i < 100; i++)
            {
                Number1 = rnd.Next(0, 52);
                Number2 = rnd.Next(0, 52);

                temp = deck[Number1];
                deck[Number1] = deck[Number2];
                deck[Number2] = temp;
            }
        }
        public void Print()
        {
            foreach (PlayingCard card in deck)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
