using Decorator.Component;

namespace Decorator.Decorator
{
    public class NotifierDecorator : INotifier
    {
        private readonly INotifier _notifierWrappee;

        protected NotifierDecorator(INotifier notifierSource)
        {
            _notifierWrappee = notifierSource;
        }

        public virtual void Send(string message)
        {
            _notifierWrappee.Send(message);
        }
    }
}