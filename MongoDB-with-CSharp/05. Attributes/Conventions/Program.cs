using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson;

namespace Conventions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var conventionPack = new ConventionPack
            {
                new CamelCaseElementNameConvention()
            };

            ConventionRegistry.Register("camelCase", conventionPack, t => true);

            Person tom = new Person { Name = "Tom", Age = 38 };

            Console.WriteLine(tom.ToBsonDocument()); // { "name" : "Tom", "age" : 38 }
        }
    }
}