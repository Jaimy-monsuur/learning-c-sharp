using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace mongodb_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        public void Start()
        {
            DAL dal = new DAL();
            List<Student> grades = dal.GET_NBR_Grades(20);// gaat 10 grades ophalen
            Print_Grades(grades);
            //AddTestVersion(db);
            Console.ReadKey();  

        }

        public void Print_Grades(List<Student> grades)//Application
        {
            foreach (Student s in grades)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---NEXT ITEM---");
                Console.ResetColor();
                Console.WriteLine($"ID: {s.id}");
                Console.WriteLine($"Student ID: {s.Student_ID}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     ---Scores---");
                Console.ResetColor();
                foreach (Scores sc in s.Scores)
                {
                    Console.WriteLine("     Type: " + sc.Type);
                    Console.WriteLine("     Score: " + sc.Score);
                }
                Console.WriteLine($"Class ID: {s.classID}");
                Console.WriteLine();
            }
        }

    }
}
