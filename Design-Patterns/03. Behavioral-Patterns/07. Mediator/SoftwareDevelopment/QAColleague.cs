namespace SoftwareDevelopment
{
    public class QAColleague : Colleague
    {
        public QAColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message for QA: " + message);
        }
    }
}
