﻿namespace FileSystem
{
    public abstract class Component
    {
        protected string name;

        public Component(string _name)
        {
            name = _name;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }
}
