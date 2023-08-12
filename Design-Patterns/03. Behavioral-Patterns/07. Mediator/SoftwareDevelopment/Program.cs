namespace SoftwareDevelopment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new CustomerColleague(mediator);
            Colleague developer = new DeveloperColleague(mediator);
            Colleague qa = new QAColleague(mediator);

            mediator.Customer = customer;
            mediator.Developer = developer;
            mediator.QA = qa;

            customer.Send("I need new software.");
            developer.Send("Software is ready. Need to be tested.");
            qa.Send("Tests are done. Software is ready for sale.");

            Console.Read();
        }
    }
}