namespace SoftwareDevelopment
{
    public class ManagerMediator : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Developer { get; set; }
        public Colleague QA { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if (Customer == colleague)
            {
                Developer.Notify(msg);
            }
            else if (Developer == colleague)
            {
                QA.Notify(msg);
            }
            else if (QA == colleague)
            {
                Customer.Notify(msg);
            }
        }
    }
}
