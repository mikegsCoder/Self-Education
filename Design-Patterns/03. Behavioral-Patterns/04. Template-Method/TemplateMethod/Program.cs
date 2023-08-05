namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass concreteClass = new ConcreteClass();

            concreteClass.TemplateMethod();
        }
    }
}