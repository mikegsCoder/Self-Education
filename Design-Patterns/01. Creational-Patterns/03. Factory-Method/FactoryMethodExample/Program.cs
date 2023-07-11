namespace FactoryMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("Panel buildings");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Wooden buildings");
            House house = dev.Create();

            Console.ReadLine();
        }
    }
}