namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "Opel", new PetrolMove());
            car.Move();

            car.Movable = new ElectricMove();
            car.Move();

            Console.ReadLine();
        }
    }
}