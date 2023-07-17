namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            
            facade.Operation1();
            facade.Operation2();
        }
    }
}