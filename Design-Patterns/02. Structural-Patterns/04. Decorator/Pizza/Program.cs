namespace Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // Italian pizza with tomatoes
            Console.WriteLine("Name: {0}", pizza1.Name);
            Console.WriteLine("Price: {0}", pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);// Italian pizza with cheese
            Console.WriteLine("Name: {0}", pizza2.Name);
            Console.WriteLine("Price: {0}", pizza2.GetCost());

            Pizza pizza3 = new BulgarianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);// Bulgarian pizza with tomatoes and cheese
            Console.WriteLine("Name: {0}", pizza3.Name);
            Console.WriteLine("Price: {0}", pizza3.GetCost());

            Console.ReadLine();
        }
    }
}