namespace AbstractFactoryExample.Products
{
    public class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Shot from arbalet.");
        }
    }
}
