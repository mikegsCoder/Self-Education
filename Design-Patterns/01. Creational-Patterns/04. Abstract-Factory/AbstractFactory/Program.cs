using AbstractFactory.Clients;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factories.AbstractFactory factory1 = new ConcreteFactory1();
            Factories.AbstractFactory factory2 = new ConcreteFactory2();

            Client client1 = new Client(factory1);
            Client client2 = new Client(factory2);

            client1.Run();
            client2.Run();
        }
    }
}