using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartNewGame()
        {
            cardgame.Shuffle();
            for (int i = 1; i < 53; i++)
            {
                if (i % 2 == 0)
                {
                    player2.AddCard(cardgame.deck[i - 1]);
                }
                else
                {
                    player1.AddCard(cardgame.deck[i - 1]);
                }
            }

        }
        public bool EndOfGame()
        {
            bool End = false;
            if (player1.cards.Count==0 || player2.cards.Count == 0)
            {
                End = true;
            }
            return End;
        }
        public void NextCard()
        {
            PlayingCard pl1 = player1.GetNextCard();
            PlayingCard pl2 = player2.GetNextCard();

            Console.WriteLine($"[{ player1.Name}] {pl1.ToString()} - [{ player2.Name}] {pl2.ToString()}");

            if (pl1.rank > pl2.rank)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player1.Name} got the cards");
                player1.AddCard(pl1);
                player1.AddCard(pl2);
            }
            else if (pl1.rank < pl2.rank)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player2.Name} got the cards");
                player2.AddCard(pl2);
                player2.AddCard(pl1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"cards left: [{player1.Name}] {player1.cards.Count}x, [{player2.Name}] {player2.cards.Count}x");
                
            }
            Console.ResetColor();
        }
    }
}
