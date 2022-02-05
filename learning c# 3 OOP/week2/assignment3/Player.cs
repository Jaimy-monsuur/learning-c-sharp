using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class Player
    {
        public string Name;
        public List<PlayingCard> cards = new List<PlayingCard>();

        public Player(string Name)
        {
            this.Name = Name;
        }
        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }
        public PlayingCard GetNextCard()
        {
            PlayingCard removed = cards[0];
            cards.RemoveAt(0);
            return removed;
        }
    }
}
