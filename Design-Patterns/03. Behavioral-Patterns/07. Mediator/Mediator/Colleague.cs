namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator _mediator)
        {
            mediator = _mediator;
        }
    }
}
