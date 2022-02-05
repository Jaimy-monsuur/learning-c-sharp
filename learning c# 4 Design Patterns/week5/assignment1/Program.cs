using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        public void start()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("main", "starting");
            MainSystem mainSystem = new MainSystem();
            logger.Log("main", "Finishing");
        }
    }
}
