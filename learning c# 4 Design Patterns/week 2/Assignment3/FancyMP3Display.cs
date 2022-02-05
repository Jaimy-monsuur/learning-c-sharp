using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class FancyMP3Display : IObserver
    {
        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: {song.Title} by {song.Artist} ({song.Duration:mm\\:ss})");
        }
        public FancyMP3Display(IObservable mp3)
        {
            mp3.AddObserver(this);
        }
    }
}
