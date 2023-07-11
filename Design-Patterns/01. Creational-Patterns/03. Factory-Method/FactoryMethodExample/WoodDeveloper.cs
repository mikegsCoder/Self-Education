namespace FactoryMethodExample
{
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
