using MongoDB.Bson;
using MongoDB.Driver;

namespace FindOneAndUpdateAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            //var result1 = await collection.FindOneAndUpdateAsync(
            //    new BsonDocument("Name", "Tom"),          // filter
            //    new BsonDocument("$set", new BsonDocument("Age", 39)));
            var result1 = collection.FindOneAndUpdate(
                new BsonDocument("Name", "Tom"),          // filter
                new BsonDocument("$set", new BsonDocument("Age", 39)));

            if (result1 == null)
                Console.WriteLine("Document not found.");
            else
                Console.WriteLine($"Updated document: {result1}");

            Console.WriteLine(new string('-', 50));

            //var result2 = await collection.FindOneAndUpdateAsync(
            //    new BsonDocument("Name", "Tom"),          // filter
            //    new BsonDocument("$set", new BsonDocument("Age", 22)),
            //    new FindOneAndUpdateOptions<BsonDocument>() { ReturnDocument = ReturnDocument.After });
            var result2 = collection.FindOneAndUpdate(
                new BsonDocument("Name", "Tom"),          // filter
                new BsonDocument("$set", new BsonDocument("Age", 22)),
                new FindOneAndUpdateOptions<BsonDocument>() { ReturnDocument = ReturnDocument.After });

            if (result2 == null)
                Console.WriteLine("Document not found.");
            else
                Console.WriteLine($"Document after update: {result2}");

            Console.WriteLine(new string('-', 50));
        }
    }
}