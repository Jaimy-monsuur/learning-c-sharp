using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public Song(string title, string artist, TimeSpan duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }
    }
}
