using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class PlayingCard
    {
        public int rank;
        public CardSuit suit;

        public PlayingCard(CardSuit suit, int number)
        {

            this.rank = number;
            this.suit = suit;
        }

        public override string ToString()
        {
            if (rank == 14)
            {
                return $"Ace of {suit}";
            }
            else if (rank == 11)
            {
                return $"Jack of {suit}";
            }
            else if (rank == 12)
            {
                return $"Queen of {suit}";
            }
            else if (rank == 13)
            {
                return $"King of {suit}";
            }
            else
            {
                return $"{rank} of {suit}";
            }
 
        }
    }
}
