using System;
using System.Collections.Generic;

namespace Programmeren3_opgaven
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Opgave1();
            Console.WriteLine();
            Opgave2();
            Console.WriteLine();
            Opgave3();
            Console.WriteLine();
            Opgave5();
            Opgave6();
        }

        void Opgave1()
        {
            Score score = new Score(6, 500);
            Console.WriteLine(score);
        }
        void Opgave2()
        {
            Score score1 = new Score(3, 600);
            BonusScore bonusScore1 = new BonusScore(7, 500, 8);
            Score score2 = new Score(6, 750);
            BonusScore bonusScore2 = new BonusScore(4, 240, 6);

            List<Score> scorelist = new List<Score>();
            scorelist.Add(score1);
            scorelist.Add(bonusScore1);
            scorelist.Add(score2);
            scorelist.Add(bonusScore2);

            foreach (Score score in scorelist)
            {
                Console.WriteLine(score);
            }
        }
        void Opgave3()
        {
            Score score1 = new Score(1, 20);
            Score score2 = new Score(2, 40);
            BonusScore bonusScore1 = new BonusScore(3, 50, 9);
            GameScore gameScore = new GameScore("Guest game", DateTime.Now);

            gameScore.Scores.Add(score1);
            gameScore.Scores.Add(score2);
            gameScore.Scores.Add(bonusScore1);

            foreach (Score score in gameScore.Scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine($"GameScore Value: {gameScore.Waarde}");
        }
        void Opgave5()
        {
            Container zak = new Zak(5,0);
            zak.Voegtoe(new Edelsteen(1,20));
            zak.Voegtoe(new Edelsteen(2, 40));
            zak.Voegtoe(new Wapen(2, Wapens.Zwaard));
        }
        void Opgave6()
        {
            Container kist = new Kist(5, 0);
            kist.Voegtoe(new Voedsel(1, 50));
            kist.Voegtoe(new Voedsel(1, 50));

            Container zak = new Zak(5, 0);
            zak.Voegtoe(new Edelsteen(1, 20));
            zak.Voegtoe(new Edelsteen(2, 40));
            zak.Voegtoe(new Wapen(2, Wapens.Zwaard));

            kist.Voegtoe(zak);

        }

    }
}
