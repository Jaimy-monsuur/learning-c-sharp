using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Pencil : IPencil
    {
        private int maxToWrite; // number of characters to write with a sharpened pencil
        private int nrOfCharsWritten; // number of written characters
        public bool CanWrite
        {
            get
            {
                if (nrOfCharsWritten > maxToWrite)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public Pencil(int maxtowrite)
        {
            this.maxToWrite = maxtowrite;
        }
        public void AfterSharpening()
        {
            nrOfCharsWritten = default;
        }

        public void Write(string message)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char c in message)
            {
                nrOfCharsWritten++;
                if (CanWrite == false)
                {
                    Console.Write('#');
                }
                else
                {
                Console.Write(c);
                }
            }
            Console.ResetColor();
        }
    }
}
