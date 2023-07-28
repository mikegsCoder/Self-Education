namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;

            FlyweightFactory f = new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fd = f.GetFlyweight("D");
            fd.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();

            uf.Operation(--extrinsicstate);
        }
    }
}