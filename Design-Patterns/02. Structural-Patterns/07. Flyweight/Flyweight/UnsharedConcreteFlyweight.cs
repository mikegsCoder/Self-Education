namespace Flyweight
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        int allState;

        public override void Operation(int extrinsicState)
        {
            allState = extrinsicState;
        }
    }
}
