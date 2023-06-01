using MongoDB.Bson;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { Name = "Tom", Email = "tom@somemail.com" };
            
            Console.WriteLine(tom.ToBsonDocument());
        }
    }
}