namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if (Colleague1 == colleague)
            {
                Colleague2.Notify(msg);
            }
            else
            {
                Colleague1.Notify(msg);
            }
        }
    }
}
