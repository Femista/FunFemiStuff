using Mediator.Component;

namespace Mediator.Mediator
{
    public class CarMediator : IMediator
    {
        private readonly Pedal _pedal;
        private readonly Engine _engine;

        public CarMediator(Pedal pedal, Engine engine)
        {
            _pedal = pedal;
            _pedal.SetMediator(this);
            _engine = engine;
            _engine.SetMediator(this);
        }

        public void Notify(BaseComponent sender, string ev)
        {
            switch (ev)
            {
                case "Go":
                    _engine.Drive();
                    break;
                case "Brake":
                    _engine.Stop();
                    break;
                case "Drive":
                    _pedal.AllowBraking(true);
                    break;
                case "Stop":
                    _pedal.AllowBraking(false);
                    break;
            }
        }
    }
}