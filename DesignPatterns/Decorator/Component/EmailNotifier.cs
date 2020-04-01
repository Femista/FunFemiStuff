using System;

namespace Decorator.Component
{
    public class EmailNotifier : INotifier
    {
        private readonly string _email;
        public EmailNotifier(string email)
        {
            _email = email;
        }
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to email: {_email}");
        }
    }
}