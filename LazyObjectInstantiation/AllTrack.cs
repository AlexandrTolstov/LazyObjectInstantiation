using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    class AllTrack
    {
        private Song[] allSongs = new Song[10000];
        public AllTrack()
        {
            Console.WriteLine("Filling up the songs!");
        }
    }
}
