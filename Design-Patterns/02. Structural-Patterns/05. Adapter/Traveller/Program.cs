namespace Traveller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // traveller
            Driver driver = new Driver();

            // car
            Auto auto = new Auto();

            // travelling with car
            driver.Travel(auto);

            // camel
            Camel camel = new Camel();

            // using Adapter
            ITransport camelTransport = new CamelToTransportAdapter(camel);

            // continue travelling in the desert
            driver.Travel(camelTransport);

            Console.Read();
        }
    }
}