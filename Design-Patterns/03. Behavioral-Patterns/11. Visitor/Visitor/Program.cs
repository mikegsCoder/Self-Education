namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var structure = new ObjectStructure();

            structure.Add(new ElementA());
            structure.Add(new ElementB());

            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());
        }
    }
}