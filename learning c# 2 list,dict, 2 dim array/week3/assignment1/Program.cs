using System;
using System.Collections.Generic;
using static assignment1.Course;

namespace assignment1
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
            List<Course> gradeList = ReadGradeList(3);
            DisplayGradeList(gradeList);
            
            Console.ReadKey();
        }
        Course ReadCourse(string question)
        {
            //aanroepen vanaf program;
            Console.WriteLine(question);
            Course course = new Course();
            course.Name = ReadName("Name of the course: ");
            course.Grade = ReadInt($"Grade for {course.Name}: ", 0, 120);
            course.practical = ReadPracticalGrade($"Practical Grade for {course.Name}: ");
            Console.WriteLine();

            return course;
        }
        PracticalGrade ReadPracticalGrade(string question)
        {
            int value = ReadInt(question);
            while (!Enum.IsDefined(typeof(PracticalGrade), value))
            {
                value = ReadInt(question);
            }
            PracticalGrade grade = (PracticalGrade)value;
            return grade;
        }

        List<Course> ReadGradeList(int nrOfCourses)
        {
            List<Course> gradeList = new List<Course>();
            Course course = new Course(); 
            
            course.status = "";
            int countP = 0;
            int retake = 3;


            for (int i = 0; i < nrOfCourses ; i++)
            {

                gradeList.Add(ReadCourse("Enter a course."));

                 bool passed = course.Passed() ;
                 if (passed == true)
                 {
                    countP++;
                 }
                
            }
            return gradeList;

        }

        void DisplayCourse(Course course)
        {
            
            Console.Write(course.Name + "   :   " + course.Grade + "    ");
            DisplayPracticalGrade(course.practical);
            Console.WriteLine();
            
        }

        void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.Write(practical);
        }

        void DisplayGradeList(List<Course> gradeList)
        {
            int nrOfRetakes = 0; bool cumLaude = true;

            foreach (Course c in gradeList)
            {
                DisplayCourse(c);
                if (!c.Passed()) nrOfRetakes++;
                if (!c.CumLaude()) { cumLaude = false; }
            }

            if (nrOfRetakes > 0)
            {
                 Console.WriteLine("Too bad, you did not graduate, you got {0} retakes.", nrOfRetakes);
            }
            else
            {
                if (cumLaude) Console.WriteLine("Congratulations, you graduated Cum Laude!");
                else Console.WriteLine("Congratulations, you graduated!");
            }
            
        }

        //van week1
        public int ReadInt(string question)
        {
            Console.Write(question);
            int Value = int.Parse(Console.ReadLine());
            return Value;
        }


        public int ReadInt(string question, int min, int max)
        {
            Console.Write(question);
            int Grade = int.Parse(Console.ReadLine());
            return Grade;
        }

        public string ReadName(string question)
        {
            Console.Write(question);
            string Name = Console.ReadLine();
            return Name;
        }
    }
}
