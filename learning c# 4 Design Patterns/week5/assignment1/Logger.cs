using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class Logger
    {
        private static Logger uniqueInstance;
        private int numberOfLines = 0;

        private Logger() { }// private ctor

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }

        public void Log(string systemname, string systemwork)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{systemname}] {systemwork}");
        }

    }
}
