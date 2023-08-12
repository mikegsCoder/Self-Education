namespace SoftwareDevelopment
{
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator _mediator)
        {
            mediator = _mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }

        public abstract void Notify(string message);
    }
}
