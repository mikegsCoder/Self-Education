namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Proxy();

            subject.Request();
        }
    }
}