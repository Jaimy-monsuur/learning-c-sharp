using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2
{
    class Album : IVinylAlbum
    {
        private string _Band;
        private string _Title;
        private int _Year;


        public Album(string title, string band, int year)
        {
            _Title = title;
            _Band = band;
            _Year = year;
        }

        public void Pause()
        {
            Console.WriteLine($"paused playing album {this}");
        }

        public void Play()
        {
            Console.WriteLine($"playing album {this}");
        }

        public void Stop()
        {
            Console.WriteLine($"stop playing album {this}");
        }

        public override string ToString()
        {
            return ($"'{_Title}, {_Band} ({_Year})'");
        }
    }
}
