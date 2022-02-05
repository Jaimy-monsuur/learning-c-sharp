using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class MP3Player : IObservable
    {
        public List<Song> songs;
        public List<IObserver> schermen;
        public Song CurrentSong { get; private set; }
        public Random rnd = new Random();

        public MP3Player()
        {
            songs = new List<Song>();
            TimeSpan s1 = new TimeSpan(0, 5, 24);
            songs.Add(new Song("Papillon", "Editors", s1));
            TimeSpan s2 = new TimeSpan(0, 5, 39);
            songs.Add(new Song("Wish You Were Here", "Pink Floyd", s2));
            TimeSpan s3 = new TimeSpan(0, 5, 26);
            songs.Add(new Song("Dazed and Confused", "Led Zeppelin", s3));
            TimeSpan s4 = new TimeSpan(0, 3, 31);
            songs.Add(new Song("Billionaire", "Bruno Mars", s4));

            schermen = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            schermen.Add(observer);

        }

        public void NextSong() 
        {
            int r = rnd.Next(songs.Count);
            Song temp = songs[r];

            if (temp == CurrentSong)
            {
                while (temp == CurrentSong)
                {
                    r = rnd.Next(songs.Count);
                    temp = songs[r];
                }
            }

            this.CurrentSong = temp;

            foreach (IObserver scherm in schermen)
            {
                scherm.Update(CurrentSong);
            }
            Console.WriteLine();
        }

        public void RemoveObserver(IObserver observer)
        {
            schermen.Remove(observer);
        }
    }
}
