using MongoDB.Bson;
using MongoDB.Driver;

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

            // another way to create the same projection:
            // var users2 = await collection.Find("{}").Project("{Name:1, Age:1, _id:0}").ToListAsync();
            var users2 = collection.Find("{}").Project("{Name:1, Age:1, _id:0}").ToList();

            foreach (var user in users2) Console.WriteLine(user);
            Console.WriteLine(separator);

            // project documents to POCO:
            // var users3 = await collection.Find("{}")
            //    .Project(doc => new Person(doc["Name"].ToString()))
            //    .ToListAsync();
            var users3 = collection.Find("{}")
                .Project(doc => new Person(doc["Name"].ToString()))
                .ToList();

            foreach (var user in users3) Console.WriteLine(user.Name);
            Console.WriteLine(separator);
        }
    }
}