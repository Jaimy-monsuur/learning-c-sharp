using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2
{
    class Single : IVinylSingle
    {
        private string _Artist;
        private int _Ranking;
        private string _Title;

        public Single(int ranking, string title, string artist)
        {
            _Artist = artist;
            _Ranking = ranking;
            _Title = title;
        }

        public void Pause()
        {
            Console.WriteLine($"pause playing single {this}");
        }

        public void Play()
        {
            Console.WriteLine($"playing single {this}");
        }

        public void Stop()
        {
            Console.WriteLine($"stop playing single {this}");
        }

        public override string ToString()
        {
            return ($"'{_Title}, {_Artist} ({_Ranking})'");
        }
    }
}
