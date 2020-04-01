using State.Context;

namespace State.State
{
    public abstract class State
    {
        protected readonly AudioPlayer Player;

        protected State(AudioPlayer player)
        {
            Player = player;
        }

        public abstract void ClickPlay();
        public abstract void ClickLock();
        public abstract void ClickNext();
        public abstract void ClickPrevious();
    }
}