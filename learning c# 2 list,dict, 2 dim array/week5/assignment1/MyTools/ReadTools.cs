using System;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string vraag)
        {
            Console.Write(vraag);
            int Value = int.Parse(Console.ReadLine());
            return Value;
        }

        public static int ReadInt(string question, int min, int max)
        {
            Console.Write(question);
            int Age = int.Parse(Console.ReadLine());

            while (Age <= min || Age >= max)
            {
                Console.Write(question);
                Age = int.Parse(Console.ReadLine());
            }
            return Age;
        }

        public static string ReadString(string vraag)
        {
            Console.Write(vraag);
            string String = Console.ReadLine();
            return String;
        }
    }
}
