namespace SimpleFactory.Products
{
    public class Samsung : IMobile
    {
        public Samsung(string model, decimal price)
        {
            Model = model;
            Price = price;
        }

        public string Model { get; private set; }
        public decimal Price { get; private set; }
    }
}
