using System;
using System.Collections.Generic;
using System.IO;

namespace opdracht2
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
            List<IVinylSingle> singles = ReadSingles(@"C:\Users\basti\Desktop\design patterns oefen tentamen\oefententamen\opdracht2\excel\singles.csv");
            List<IVinylAlbum> albums = ReadAlbums(@"C:\Users\basti\Desktop\design patterns oefen tentamen\oefententamen\opdracht2\excel\albums.csv");

            // create jukebox
            JukeBox jukeBox = new JukeBox(singles);

            if (albums.Count > 0)
            {
                foreach (IVinylAlbum album in albums)
                {
                    jukeBox._Singles.Add(new AlbumAdapter(album));
                }
            }

            // select single
            Console.Write("Select a single to play {0}..{1}: ", 1, jukeBox._Singles.Count);
            int index = int.Parse(Console.ReadLine());

            while (index > 0)
            {
                jukeBox.SelectSingle(index);

                // play selected single
                jukeBox.Afspelen();

                Console.WriteLine();

                // select next single
                Console.Write("Select a number to play {0}..{1}: ", 1, jukeBox._Singles.Count);
                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("end of program...");
            Console.ReadKey();
        }

        List<IVinylSingle> ReadSingles(string filename)
        {
            // format file: <ranking;title;artist>

            List<IVinylSingle> singles = new List<IVinylSingle>();

            if (!File.Exists(filename))
                return singles;

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] items = line.Split(';');
                Single single = new Single(int.Parse(items[0]), items[1], items[2]);
                singles.Add(single);
            }
            reader.Close();

            return singles;
        }

        List<IVinylAlbum> ReadAlbums(string filename)
        {
            // format file: <title;band;year>

            List<IVinylAlbum> albums = new List<IVinylAlbum>();

            if (!File.Exists(filename))
                return albums;

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] items = line.Split(';');
                Album album = new Album(items[0], items[1], int.Parse(items[2]));
                albums.Add(album);
            }
            reader.Close();

            return albums;
        }
    }
}
