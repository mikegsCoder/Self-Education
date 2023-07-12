namespace AbstractFactoryExample.Products
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("We fly.");
        }
    }
}
