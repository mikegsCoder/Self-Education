namespace SoftwareDevelopment
{
    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator)
           : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message for customer: " + message);
        }
    }
}
