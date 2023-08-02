namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);

            invoker.SetCommand(command);
            invoker.Run();
        }
    }
}