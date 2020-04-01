using System;
using State.State;

namespace State.Context
{
    public class AudioPlayer
    {
        private State.State _state;
        public bool Playing;

        public AudioPlayer()
        {
            _state = new ReadyState(this);
        }

        public void ChangeState(State.State state)
        {
            _state = state;
        }

        public void ClickPlay()
        {
            Console.WriteLine("Play button pressed");
            _state.ClickPlay();
        }

        public void ClickLock()
        {
            Console.WriteLine("Lock button pressed");
            _state.ClickLock();
        }

        public void ClickNext()
        {
            Console.WriteLine("Next button pressed");
            _state.ClickNext();
        }

        public void ClickPrevious()
        {
            Console.WriteLine("Previous button pressed");
            _state.ClickPrevious();
        }

        public void StartPlayback()
        {
            Console.WriteLine("Starting playback");
            Playing = true;
        }

        public void StopPlayback()
        {
            Console.WriteLine("Stopping playback");
            Playing = false;
        }

        public void NextSong()
        {
            Console.WriteLine("Next song");
        }

        public void PreviousSong()
        {
            Console.WriteLine("Previous song");
        }
    }
}