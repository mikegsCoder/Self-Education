using MongoDB.Bson;
using MongoDB.Driver;

namespace FindOneAndReplaceAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            // replace where Name == "Tom" with {{"Name", "Tomas"}, { "Age", 22}}
            //var result1 = await collection.FindOneAndReplaceAsync(new BsonDocument("Name", "Tom"), new() { { "Name", "Tomas" }, { "Age", 22 } });
            var result1 = collection.FindOneAndReplace(new BsonDocument("Name", "Tom"), new() { { "Name", "Tomas" }, { "Age", 22 } });
            
            if (result1 == null)
                Console.WriteLine("Document not found.");
            else
                Console.WriteLine($"Document replaced: {result1}");

            Console.WriteLine(new string('-', 50));

            // result2 returns document after replacement:
            //var result2 = await collection.FindOneAndReplaceAsync(
            //    new BsonDocument("Name", "Tomas"),                     // filter
            //    new BsonDocument { { "Name", "Tom" }, { "Age", 38 } }, // new document
            //    new FindOneAndReplaceOptions<BsonDocument>() { ReturnDocument = ReturnDocument.After });
            var result2 = collection.FindOneAndReplace(
                new BsonDocument("Name", "Tomas"),                     // filter
                new BsonDocument { { "Name", "Tom" }, { "Age", 38 } }, // new document
                new FindOneAndReplaceOptions<BsonDocument>() { ReturnDocument = ReturnDocument.After });

            if (result2 == null)
                Console.WriteLine("Document not found.");
            else
                Console.WriteLine($"New Document: {result2}");

            Console.WriteLine(new string('-', 50));
        }
    }
}