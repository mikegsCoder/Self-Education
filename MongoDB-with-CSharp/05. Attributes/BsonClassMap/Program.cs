using MongoDB.Bson;

namespace BsonClassMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoDB.Bson.Serialization.BsonClassMap.RegisterClassMap<Person>(cm =>
            {
                cm.AutoMap();
                cm.MapMember(p => p.Name).SetElementName("username");
            });

            Person tom = new Person { Name = "Tom", Age = 38 };

            Console.WriteLine(tom.ToBsonDocument()); // { "username" : "Tom", "Age" : 38 }
        }
    }
}