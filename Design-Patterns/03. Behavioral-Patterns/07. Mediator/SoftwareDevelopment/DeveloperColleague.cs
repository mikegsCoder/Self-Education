namespace SoftwareDevelopment
{
    public class DeveloperColleague : Colleague
    {
        public DeveloperColleague(Mediator mediator)
           : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message for developer: " + message);
        }
    }
}
