using MongoDB.Bson;
using MongoDB.Driver;

namespace GetSingleDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new string('-', 50);

            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            // get first document
            // var user1 = await collection.Find("{}").FirstAsync();
            var user1 = collection.Find("{}").First();
            Console.WriteLine(user1);
            Console.WriteLine(separator);

            // get first document, where Age = 42
            // var user2 = await collection.Find(new BsonDocument("Age", 42)).FirstAsync();
            var user2 = collection.Find(new BsonDocument("Age", 42)).First();
            Console.WriteLine(user2);
            Console.WriteLine(separator);

            // skip first 2 documents
            // var users = await collection.Find("{}").Skip(2).ToListAsync();
            var users1 = collection.Find("{}").Skip(2).ToList();
            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

            // get first 2 documents
            // var users = await collection.Find("{}").Limit(3).ToListAsync();
            var users2 = collection.Find("{}").Limit(2).ToList();
            foreach (var user in users2) Console.WriteLine(user);
            Console.WriteLine(separator);
        }
    }
}