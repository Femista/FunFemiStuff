using Mediator.Mediator;

namespace Mediator.Component
{
    public abstract class BaseComponent
    {
        protected IMediator _mediator;

        protected BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}