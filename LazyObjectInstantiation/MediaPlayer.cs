using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    class MediaPlayer
    {
        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        private Lazy<AllTrack> allSongs = new Lazy<AllTrack>(() => {
            Console.WriteLine("Creating AllTracks object!");
            return new AllTrack();
        });
        public AllTrack GetAllTrack()
        {
            return allSongs.Value;
        }
    }
}
