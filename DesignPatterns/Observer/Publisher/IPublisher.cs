using Observer.Subscriber;

namespace Observer.Publisher
{
    public interface IPublisher
    {
        void Attach(ISubscriber subscriber);
        void Detach(ISubscriber subscriber);
        void Notify();
    }
}