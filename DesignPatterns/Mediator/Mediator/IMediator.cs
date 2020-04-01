using Mediator.Component;

namespace Mediator.Mediator
{
    public interface IMediator
    {
        void Notify(BaseComponent sender, string ev);
    }
}