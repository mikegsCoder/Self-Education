namespace FactoryMethodExample
{
    public abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        // Factory Method
        abstract public House Create();
    }
}
