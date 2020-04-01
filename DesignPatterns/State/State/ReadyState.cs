using State.Context;

namespace State.State
{
    public class ReadyState : State
    {
        public ReadyState(AudioPlayer player) : base(player)
        {
        }

        public override void ClickPlay()
        {
            Player.StartPlayback();
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