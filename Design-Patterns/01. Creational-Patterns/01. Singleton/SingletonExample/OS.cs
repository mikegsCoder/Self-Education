﻿namespace SingletonExample
{
    public class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name)
        {
            Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
            {
                instance = new OS(name);
            }

            return instance;
        }
    }
}
