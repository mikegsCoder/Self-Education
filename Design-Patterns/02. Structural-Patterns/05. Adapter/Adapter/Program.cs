namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.Request(new Target());
        }
    }
}