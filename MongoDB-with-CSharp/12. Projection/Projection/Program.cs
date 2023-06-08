using MongoDB.Bson;
using MongoDB.Driver;
using System.Net.Cache;

namespace Projection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new string('-', 50);

            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            // create ProjectionDefinition that includes Name and Age:
            var projection = Builders<BsonDocument>.Projection.Include("Name").Include("Age").Exclude("_id");

            // var users1 = await collection.Find(new BsonDocument()).Project(projection).ToListAsync();
            var users1 = collection.Find(new BsonDocument()).Project(projection).ToList();

            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

        }
    }
}