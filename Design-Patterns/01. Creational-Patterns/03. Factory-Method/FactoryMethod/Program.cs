namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productA = new ConcreteCreatorA().FactoryMethod();
            Product productB = new ConcreteCreatorB().FactoryMethod();
        }
    }
}