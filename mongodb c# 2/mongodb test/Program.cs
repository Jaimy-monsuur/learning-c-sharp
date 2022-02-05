using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace mongodb_test
{
    class Program
    {
        public List<Opleiding> list;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        public void Start()
        {
            DAL dal = new DAL();
            list = dal.GetCollecction("Gediplomeerde");
            Top5();
        }

        public void Top5()
        {
            List<Opleiding> listhaarlem = new List<Opleiding>();
            foreach (Opleiding item in list)
            {
                if (item.GEMEENTENAAM == "Haarlem")
                {
                    listhaarlem.Add(item);
                }
            }

            List<Opleiding_Totaal_2018> opleiding_Totaal_2018 = new List<Opleiding_Totaal_2018>();
            foreach (Opleiding item1 in listhaarlem)
            {
                if (item1.GESLACHT == "man")
                {
                    foreach (Opleiding item2 in listhaarlem)
                    {
                        if (item1.OPLEIDINGSNAAMACTUEEL == item2.OPLEIDINGSNAAMACTUEEL && item1.INSTELLINGSNAAMACTUEEL == item2.INSTELLINGSNAAMACTUEEL && item2.GESLACHT == "vrouw")
                        {
                            Opleiding_Totaal_2018 t = new Opleiding_Totaal_2018()
                            {
                                _2018 = item1._2018 + item2._2018,
                                GEMEENTENAAM = item1.GEMEENTENAAM,
                                INSTELLINGSNAAMACTUEEL = item1.INSTELLINGSNAAMACTUEEL,
                                OPLEIDINGSNAAMACTUEEL = item1.OPLEIDINGSNAAMACTUEEL
                            };
                            opleiding_Totaal_2018.Add(t);
                            break;
                        }
                    }
                }
            }
            List<Opleiding_Totaal_2018> top5 = opleiding_Totaal_2018.OrderByDescending(x => x._2018).Take(5).ToList();
            Console.WriteLine("Top 5 opleidingen haarlem:");
            int i = 0;
            foreach (Opleiding_Totaal_2018 item in top5)
            {
                i++;
                Console.WriteLine(i + " " + item.INSTELLINGSNAAMACTUEEL);
                Console.WriteLine(item.OPLEIDINGSNAAMACTUEEL);
                Console.WriteLine("Studenten in 2018: " + item._2018);
                Console.WriteLine();
            }
        }

    }
}
