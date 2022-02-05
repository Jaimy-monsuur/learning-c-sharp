using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class SimpleMP3Display : IObserver
    {
        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - {song.Title}");
        }

        public SimpleMP3Display(IObservable mp3)
        {
            mp3.AddObserver(this);
        }
    }
}
