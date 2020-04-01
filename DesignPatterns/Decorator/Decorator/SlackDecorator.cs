using System;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class SlackDecorator : NotifierDecorator
    {
        private readonly string _slackProfile;

        public SlackDecorator(INotifier notifierSource, string slackProfile) : base(notifierSource)
        {
            _slackProfile = slackProfile;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending '{message}' to slack profile: {_slackProfile}");
        }
    }
}