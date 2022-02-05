using System;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // maak een zonnepaneel systeem aan
            IObservable systeem = new ZonnepaneelSysteem();

            // maak een controller  aan
            IPaneelController controller = new PaneelController(systeem);

            // maak een display voor het systeem aan
            systeem.AddDisplay(new ZonneDisplay(systeem));
             
            // doe een aantal metingen
            for (int i = 0; i < 10; i++)
            {
                controller.NieuweMeting();
            }
            Console.ReadKey();
        }
    }
}
