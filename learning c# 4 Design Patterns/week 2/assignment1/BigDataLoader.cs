using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public abstract class BigDataLoader
    {
        public void ETL_Method()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces started]");
            Console.ResetColor();
            Extract();
            Transform();
            Load();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces finished]\n");
            Console.ResetColor();
        }

        public abstract void Extract();
        public abstract void Transform();

        public void Load()
        {
            Console.WriteLine("loading transformed data...");
        }

    }
}
