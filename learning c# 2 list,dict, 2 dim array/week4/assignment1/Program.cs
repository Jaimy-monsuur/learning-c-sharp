using System;
using System.IO;

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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string FileName = ($"{name}.txt");
            
            

            if (File.Exists(FileName))
            {
                Console.WriteLine($"Nice to see you again, {name}");//de hallo dinges
                Console.WriteLine("We have the following information about you: ");
                Person person = ReadPerson(FileName);
                DisplayPerson(person);
            }
            else
            {
                Console.WriteLine($"Welcome {name}!");
                Person person = ReadPerson();
                WritePerson(person, FileName);
            }

            Console.ReadKey();
        }

        Person ReadPerson()
        {
            Person person = new Person();
            Console.Write("Enter your name: ");
            person.name = Console.ReadLine();
            //Console.WriteLine($"Welcome {person.name}!");

            Console.Write("Enter your city: ");
            person.city = Console.ReadLine();

            Console.Write("Enter your age: ");
            person.age = int.Parse(Console.ReadLine());

            return person;
        }

        void DisplayPerson(Person person)
        {
            Console.WriteLine($"Name    : {person.name}");
            Console.WriteLine($"City    : {person.city}");
            Console.WriteLine($"Age    : {person.age}");
        }

        void WritePerson(Person person, string FileName)
        {
            
            StreamWriter writer = new StreamWriter(FileName);
            writer.WriteLine(person.name);
            writer.WriteLine(person.city);
            writer.WriteLine(person.age);

            //close
            writer.Close();
            Console.WriteLine("Your data is written to file.");
        }

        Person ReadPerson(string FileName)
        {
            StreamReader reader = new StreamReader(FileName);
            Person person = new Person();

            person.name = reader.ReadLine();// hoe gaat dit werken.
            person.city = reader.ReadLine();
            person.age = int.Parse(reader.ReadLine());

            //close
            reader.Close();

            return person;
        }
    }
}
