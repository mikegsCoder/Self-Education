namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create components
            Component root = new Composite("Root");
            Composite subtree = new Composite("Subtree");
            Component leaf1 = new Leaf("Leaf");
            Component leaf2 = new Leaf("Leaf");

            // Create treee
            subtree.Add(leaf2);
            root.Add(subtree);
            root.Add(leaf1);

            // Display
            root.Display();
        }
    }
}