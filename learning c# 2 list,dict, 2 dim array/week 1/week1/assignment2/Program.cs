using System;

namespace assignent2
{
    class Program
    {
        const int LenthArray = 3;
        Person[] PersonArrays = new Person[LenthArray];
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {

            for (int i = 0; i < PersonArrays.Length; i++)
            {
                PersonArrays[i] = ReadPerson(i);
                Console.WriteLine();
            }

            for (int i = 0; i < PersonArrays.Length; i++)
            {
                PrintPerson(PersonArrays[i]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        Person ReadPerson(int i)
        {

            PersonArrays[i].FirstName = Leesstring("Enter first name: ");

            PersonArrays[i].LastName = Leesstring("Enter last name: ");

            PersonArrays[i].Gender = LeesGender("Gender (m/f): ");

            PersonArrays[i].Age = LeesInt("Enter age: ");

            PersonArrays[i].City = Leesstring("Enter city: ");

            return PersonArrays[i];

        }

        void PrintPerson(Person p)
        {
            Console.WriteLine($"\n{p.FirstName} {p.LastName} ({p.Gender})\n{p.Age} years old, {p.City}");
        }


        GenderType LeesGender(string question)
        {
            Console.Write(question);
            GenderType Gender = (GenderType)Enum.Parse(typeof(GenderType), Console.ReadLine());
            return Gender;
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);
            int Value = int.Parse(Console.ReadLine());
            return Value;
        }

        string Leesstring(string vraag)
        {
            Console.Write(vraag);
            string Name = Console.ReadLine();
            return Name;
        }
    }
}
