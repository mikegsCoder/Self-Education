namespace Composite
{
    public abstract class Component
    {
        protected string name;

        public Component(string _name)
        {
            name = _name;
        }

        public abstract void Display();

        public abstract void Add(Component c);

        public abstract void Remove(Component c);
    }
}
