namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aggregate a = new ConcreteAggregate();

            Iterator i = a.CreateIterator();

            object item = i.First();

            while (!i.IsDone())
            {
                item = i.Next();
            }
        }
    }
}