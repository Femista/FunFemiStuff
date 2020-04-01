using System;
using State.Context;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var audioPlayer = new AudioPlayer();
            audioPlayer.ClickPlay();
            audioPlayer.ClickLock();
            audioPlayer.ClickNext();
            audioPlayer.ClickLock();
            audioPlayer.ClickNext();
            audioPlayer.ClickPlay();
            Console.ReadLine();
        }
    }
}
