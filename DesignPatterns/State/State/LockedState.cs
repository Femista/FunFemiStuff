using System;
using State.Context;

namespace State.State
{
    public class LockedState : State
    {
        public LockedState(AudioPlayer player) : base(player)
        {
        }

        public override void ClickPlay()
        {
            Console.WriteLine("The player is locked!");
        }

        public override void ClickLock()
        {
            if (Player.Playing)
            {
                Player.ChangeState(new PlayingState(Player));
            }
            else
            {
                Player.ChangeState(new ReadyState(Player));
            }
        }

        public override void ClickNext()
        {
            Console.WriteLine("The player is locked!");
        }

        public override void ClickPrevious()
        {
            Console.WriteLine("The player is locked!");
        }
    }
}