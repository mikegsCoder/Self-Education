namespace MacroCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            QAEngineer qa = new QAEngineer();
            SalesManager manager = new SalesManager();

            List<ICommand> commands = new List<ICommand>
            {
                new CodeCommand(dev),
                new TestCommand(qa),
                new AdvertiseCommand(manager)
            };

            CEO ceo = new CEO();
            ceo.SetCommand(new MacroCommand(commands));
            ceo.StartProject();
            ceo.StopProject();

            Console.Read();
        }
    }
}