namespace ChainOfResponsibility.Handler
{
    public class SquirrelHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            return request == "Nut" ? $"Squirrel: You KNOW I'll eat the {request}.\n" : base.Handle(request);
        }
    }
}