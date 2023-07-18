namespace Composite
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in children)
            {
                component.Display();
            }
        }
    }
}
