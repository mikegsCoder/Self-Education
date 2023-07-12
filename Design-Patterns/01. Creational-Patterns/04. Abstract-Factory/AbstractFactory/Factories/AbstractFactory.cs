using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }
}
