using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {
            ISBNValidation Validate = new ISBNValidation();
            Console.Write("Enter ISBN number: ");
            string isbn = Console.ReadLine();
            Validate = ValidateISBN(isbn);
            switch (Validate)
            {
                case ISBNValidation.ValidISBN13:
                    Console.WriteLine("Valid ISBN-13 number");
                    break;
                case ISBNValidation.InvalidISBN:
                    Console.WriteLine("Invalid ISBN-13 number");
                    break;

            }
        }

        ISBNValidation ValidateISBN(string isbn)
        {

            bool valid = false;
            if (isbn.Length >= 13)
            {
                valid = IsValidISBN13(isbn);
            }
            if (valid == true)
            {
                return ISBNValidation.ValidISBN13;
            }
            else
            {
                return ISBNValidation.InvalidISBN;
            }
        }

        bool IsValidISBN13(string isbn)
        {
            bool valid = false;
            bool stop = false;
            int som = 0;
            isbn = isbn.Replace("-", "");

                if (isbn.Length != 13)
                {
                   valid = false;
                }

                for (int i = 0; i < isbn.Length; i++)
                {
                    int number = isbn[i] - '0';
                    if (number > 9 || number < 0)
                    {
                     stop = true;
                    break;
                    }
                    else if (i % 2 == 0)
                    {
                        number = number * 3;
                    }
                    else if (number > 0 || number < 9)
                    {
                        break;
                    }
                    som += number;
                }
            if (stop == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid isbn character!"); Console.ResetColor();
                Console.WriteLine();

            }

            if (som % 10 == 0)
                {
                    valid = true;
                }
                return valid;

        }
    }
}
