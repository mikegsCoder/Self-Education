using AbstractFactoryExample.Client;
using AbstractFactoryExample.Factories;

namespace AbstractFactoryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.Hit();
            warrior.Run();

            Console.ReadLine();
        }
    }
}