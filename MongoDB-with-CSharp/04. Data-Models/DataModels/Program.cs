using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace DataModels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new String('-', 50);

            Person person1 = new Person { Name = "Tom", Age = 38 };
            person1.Company = new Company { Name = "Microsoft" };

            // ToJson():
            Console.WriteLine(person1.ToJson());

            Console.WriteLine(separator);

            BsonDocument doc = new BsonDocument
            {
                {"Name","Tom"},
                {"Age", 38},
                {"Company", new BsonDocument{ {"Name" , "Microsoft"}} },
                {"Languages", new BsonArray{"english", "german", "spanish"} }
            };

            // Deserialize<>():
            Person person2 = BsonSerializer.Deserialize<Person>(doc);
            Console.WriteLine(person2.ToJson());

            Console.WriteLine(separator);

            Person person3 = new Person
            {
                Name = "Tom",
                Age = 38,
                Company = new Company { Name = "Microsoft" },
                Languages = { "english", "german", "spanish" }
            };

            // ToBsonDocument():
            BsonDocument doc3 = person3.ToBsonDocument();
            Console.WriteLine(doc3);

            Console.WriteLine(separator);
        }
    }
}