namespace ChainOfResponsibility.Handler
{
    class MonkeyHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            return request == "Banana" ? $"Monkey: I'll eat the {request}.\n" : base.Handle(request);
        }
    }
}