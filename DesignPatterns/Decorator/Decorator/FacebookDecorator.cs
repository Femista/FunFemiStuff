using System;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class FacebookDecorator : NotifierDecorator
    {
        private readonly string _facebookProfile;

        public FacebookDecorator(INotifier notifierSource, string facebookProfile) : base(notifierSource)
        {
            _facebookProfile = facebookProfile;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending '{message}' to facebook profile: {_facebookProfile}");
        }
    }
}