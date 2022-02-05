using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2
{
    class AlbumAdapter : IVinylSingle
    {
        private IVinylAlbum _Album;

        public AlbumAdapter(IVinylAlbum album)
        {
            _Album = album;
        }

        public void Pause()
        {
            _Album.Pause();
        }

        public void Play()
        {
            _Album.Play();
        }

        public void Stop()
        {
            _Album.Stop();
        }
    }
}
