using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            BatchProcessor batchProcessor = new BatchProcessor();

            BigDataLoader callLoader = new CallDataLoader();
            BigDataLoader twitterLoader = new TwitterDataLoader();
            BigDataLoader sensorLoader = new SensorDataLoader();

            batchProcessor.AddBigDataLoader(callLoader);
            batchProcessor.AddBigDataLoader(twitterLoader);
            batchProcessor.AddBigDataLoader(sensorLoader);

            batchProcessor.Process();
        }
    }
}
