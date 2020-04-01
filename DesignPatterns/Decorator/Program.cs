using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
           var emailNotifier = new EmailNotifier("oooyenusi@smcm.edu");
           emailNotifier.Send("One email comin right up");
           var emailAndFacbookNotifier = new FacebookDecorator(emailNotifier, "Femi");
           emailAndFacbookNotifier.Send("Now an email and a facebook message");
           var emailFacebookSlackNotifier = new SlackDecorator(emailAndFacbookNotifier, "Femi");
           emailFacebookSlackNotifier.Send("Email, facebook, and slack!");
           var emailSlackNotifier = new SlackDecorator(emailNotifier, "Femi");
           emailSlackNotifier.Send("Now just email and slack");
           Console.ReadLine();
        }
    }
}
