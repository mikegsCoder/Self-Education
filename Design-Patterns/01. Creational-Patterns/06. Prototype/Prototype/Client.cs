﻿namespace Prototype
{
    public class Client
    {
        public void Operation()
        {
            Prototype prototype = new ConcretePrototype1(1);
            Prototype clone = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
        }
    }
}
