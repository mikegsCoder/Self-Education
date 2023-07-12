using AbstractFactory.Products;

namespace AbstractFactory.Clients
{
    public class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(Factories.AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }

        public void Run()
        { }
    }
}
