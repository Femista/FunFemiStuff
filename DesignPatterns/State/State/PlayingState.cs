using State.Context;

namespace State.State
{
    public class PlayingState : State
    {
        public PlayingState(AudioPlayer player) : base(player)
        {
        }

        public override void ClickPlay()
        {
            Player.StopPlayback();
            Player.ChangeState(new ReadyState(Player));
        }

        public override void ClickLock()
        {
            Player.ChangeState(new LockedState(Player));
        }

        public override void ClickNext()
        {
            Player.NextSong();
        }

        public override void ClickPrevious()
        {
            Player.PreviousSong();
        }
    }
}