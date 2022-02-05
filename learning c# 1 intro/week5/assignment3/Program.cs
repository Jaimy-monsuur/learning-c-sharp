


using System;
using System.Transactions;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tips:
            // -use two arrays: one for the names and one for the grades;
            //-the sizes of the two arrays are equal to the number of students entered.

            //declaring stuff
            double GradeTotall = 0;
            string BestStudent = "";
            double Maxgrade = 0;

            //vraag naam van de course
            Console.Write("Enter course name: ");
            string cousre = Console.ReadLine();

            // enter number of students
            Console.Write("Enter number of students: ");
            int StudentCount = int.Parse(Console.ReadLine());

            //eerste array voor de namen van de studenten. in een loop want moet netzo veel als aantal studenten gevraagdworden.
            string[] StudentNames = new string[StudentCount];
            for (int i = 0; i < StudentCount; i++)
            {
                Console.Write("Enter name of student: ");
                string name = Console.ReadLine();
                StudentNames[i] = name; 
            }

            //witregel(kan blijkbaar ook met \n, voortaan gebruiken!!!)
            Console.WriteLine();

            //tweede array voor grade
            double[] Studentgrade = new double[StudentCount];
            for (int i = 0; i < StudentCount; i++)
            {
                string name = StudentNames[i];
                Console.Write($"Enter grade of {name}: ");
                Studentgrade[i] = double.Parse(Console.ReadLine());
                double grade = Studentgrade[i];
                GradeTotall += grade;

                //kijk voor een maxgrade
                if (grade > Maxgrade)
                {
                    BestStudent = name;
                    Maxgrade = grade;
                }
            }

            //average berekenen
            double AverageGrade = GradeTotall / StudentCount;
            Console.WriteLine($"\nAverage grade: {AverageGrade:0.0}");
            Console.WriteLine($"Student {BestStudent} has maximum grade: {Maxgrade}\n");

            for (int i = 0; i < StudentCount; i++)
            {
                string name = StudentNames[i];
                double grade = Studentgrade[i];
                Console.WriteLine($"Grade for student {name} (course {cousre}): {grade}");

            }

        }
    }
}
