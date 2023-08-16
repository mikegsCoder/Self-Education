namespace Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(WaterState.LIQUID);
            water.Heat();
            water.Frost();
            water.Frost();

            Console.Read();
        }
    }
}