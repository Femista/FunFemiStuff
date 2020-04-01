namespace ChainOfResponsibility.Handler
{
    public class DogHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            return request == "Bone" ? $"Dog: I'll eat the {request}.\n" : base.Handle(request);
        }
    }
}