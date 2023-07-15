namespace Prototype
{
    public abstract class Prototype
    {
        public int Id { get; private set; }

        public Prototype(int id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }
}
