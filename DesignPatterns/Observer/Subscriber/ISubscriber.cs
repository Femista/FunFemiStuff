using Observer.Publisher;

namespace Observer.Subscriber
{
    public interface ISubscriber
    {
        void Update(IPublisher publisher);
    }
}