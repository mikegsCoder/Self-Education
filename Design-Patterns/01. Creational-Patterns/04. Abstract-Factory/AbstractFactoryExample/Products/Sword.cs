namespace AbstractFactoryExample.Products
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Fight with sword.");
        }
    }
}
