using System;
using System.Collections.Generic;
using System.IO;

namespace Opgave3
{
    class Program
    {
        const string STATERESULT_FILENAME = "2020-votes.csv";
        const string ELECTORS_FILENAME = "2020-electors.csv";
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.start();
        }

        void start()
        {
            try
            {
                List<StateResult> result = ReadStateResults(STATERESULT_FILENAME);
                List<StateElectors> stateElector = ReadStateElectors(ELECTORS_FILENAME);
                DisplayStateResults(result);
                
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message); Console.ResetColor();
                Console.WriteLine();
                throw;
            }

            Console.WriteLine("End of program");

        }

        List<StateResult> ReadStateResults(string filename)
        {
            List<StateResult> results = new List<StateResult>();
            string[] list = new string[4];
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                StateResult result = new StateResult();
                string line = reader.ReadLine();
                list = line.Split(';');
                result.StateName = list[0];
                result.CandidateName = list[1];
                result.PartyName = list[2];
                result.CandidateVotes = int.Parse(list[3]);
                results.Add(result);

            }
            reader.Close();
            return results;
        }

        List<StateElectors> ReadStateElectors(string filename)
        {
            List<StateElectors> Electorresults = new List<StateElectors>();
            string[] list = new string[2];
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                StateElectors result = new StateElectors();
                string line = reader.ReadLine();
                list = line.Split(';');
                result.StateName = list[0];
                result.ElectorsCount = int.Parse(list[1]);

                Electorresults.Add(result);
            }
            reader.Close();
            return Electorresults;
        }

        void DisplayStateResults(List<StateResult> results)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("State results");
            Console.ResetColor();
            foreach (StateResult result in results)
            {
                Console.WriteLine($"{result.StateName}: {result.CandidateName} ({result.PartyName}), {result.CandidateVotes} votes");
            }            
        }

    }
}
