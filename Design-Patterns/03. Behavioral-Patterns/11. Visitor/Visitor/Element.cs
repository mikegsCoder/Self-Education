namespace Visitor
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);

        public string SomeState { get; set; }
    }
}
