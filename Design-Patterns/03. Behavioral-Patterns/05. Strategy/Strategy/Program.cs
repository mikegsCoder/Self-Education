namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteStrategy1 strategy1 = new ConcreteStrategy1();
            ConcreteStrategy2 strategy2 = new ConcreteStrategy2();

            Context context = new Context(strategy1);
            context.ExecuteAlgorithm();

            context.ContextStrategy = strategy2;
            context.ExecuteAlgorithm();
        }
    }
}