using MongoDB.Bson;
using MongoDB.Driver;

namespace DeleteDocuments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            // delete one document where Name == "Sam":
            //var result1 = await collection.DeleteOneAsync(new BsonDocument("Name", "Sam"));
            var result1 = collection.DeleteOne(new BsonDocument("Name", "Sam"));

            WriteResult(collection, result1);

            // delete all documents where Name == "Tom":
            //var result2 = await collection.DeleteManyAsync(new BsonDocument("Name", "Tom"));
            var result2 = collection.DeleteMany(new BsonDocument("Name", "Tom"));

            WriteResult(collection, result2);

            // delete with POCO:
            var collection1 = db.GetCollection<Person>("users");

            // delete all documents where Name == "Bob":
            //var result3 = await collection.DeleteManyAsync(p => p.Name == "Bob");
            var result3 = collection1.DeleteMany(p => p.Name == "Bob");

            Console.WriteLine($"Deleted documents: {result3.DeletedCount}");

            var users = collection1.Find("{}").ToList();
            foreach (var user in users) Console.WriteLine(user.Name);

            Console.WriteLine(new string('-', 50));

            // find one and delete where Name == "Alice":
            //var result4 = await collection.FindOneAndDeleteAsync(new BsonDocument("Name", "Tom"));
            var result4 = collection.FindOneAndDelete(new BsonDocument("Name", "Alice"));

            if (result4 == null)
                Console.WriteLine("Document not found.");
            else
                Console.WriteLine($"Deleted document: {result4}");

            Console.WriteLine(new string('-', 50));
        }
        private static void WriteResult(IMongoCollection<BsonDocument> collection, DeleteResult result)
        {
            Console.WriteLine($"Deleted documents: {result.DeletedCount}");

            var users = collection.Find("{}").ToList();
            foreach (var user in users) Console.WriteLine(user);

            Console.WriteLine(new string('-', 50));
        }
    }
}