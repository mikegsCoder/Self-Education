namespace Pizza
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(string n, Pizza _pizza) : base(n)
        {
            pizza = _pizza;
        }
    }
}
