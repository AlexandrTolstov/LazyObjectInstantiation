using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instatiation ******\n");
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();
            MediaPlayer yourPlayer = new MediaPlayer();
            AllTrack yourMusic = yourPlayer.GetAllTrack();
        }
    }
}
