using SimpleFactory.Enum;
using SimpleFactory.ProductFactory;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMobile firstMobile = Factory.CreateMobile(MobileType.Nokia);
            IMobile secondMobile = Factory.CreateMobile(MobileType.Sony);
            IMobile thirdMobile = Factory.CreateMobile(MobileType.Samsung);

            Console.WriteLine(firstMobile.Price);
            Console.WriteLine(secondMobile.Price);
            Console.WriteLine(thirdMobile.Price);

            Console.ReadLine();
        }
    }
}