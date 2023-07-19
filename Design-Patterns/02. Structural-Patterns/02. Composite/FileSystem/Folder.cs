namespace FileSystem
{
    public class Folder : Component
    {
        private List<Component> components = new List<Component>();

        public Folder(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Node: " + name);
            Console.WriteLine("SubNodes:");

            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }
}
