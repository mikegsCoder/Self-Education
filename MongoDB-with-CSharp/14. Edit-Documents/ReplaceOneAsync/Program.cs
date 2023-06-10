using MongoDB.Bson;
using MongoDB.Driver;

namespace ReplaceOneAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            // set filter - document, where Name = Tom and Age = 33:
            var filter1 = new BsonDocument { { "Name", "Tom" }, { "Age", 33 } };
            
            // create new document:
            var newDocument1 = new BsonDocument { { "Name", "Tomas" }, { "Age", 34 } };
            
            // replacement:
            //var result1 = await collection.ReplaceOneAsync(filter1, newDocument1);
            var result1 = collection.ReplaceOne(filter1, newDocument1);

            Console.WriteLine($"Matched: {result1.MatchedCount}; Modified: {result1.ModifiedCount}");
            WriteResult(collection);

            // set filter - document, where Name = Alex and Age = 33:
            var filter2 = new BsonDocument { { "Name", "Alex" }, { "Age", 33 } };
            
            // create new document:
            var newDocument2 = new BsonDocument { { "Name", "Alexander" }, { "Age", 34 } };

            // replacement - if document not found, insert new document (IsUpsert = true):
            //var result2 = await collection.ReplaceOneAsync(filter2, newDocument2, new ReplaceOptions { IsUpsert = true });
            var result2 = collection.ReplaceOne(filter2, newDocument2, new ReplaceOptions { IsUpsert = true });

            Console.WriteLine($"Matched: {result2.MatchedCount}; Modified: {result2.ModifiedCount}; UpsertedId: {result2.UpsertedId}");
            WriteResult(collection);
        }

        private static void WriteResult(IMongoCollection<BsonDocument> collection)
        {
            var users = collection.Find("{}").ToList();
            foreach (var user in users) Console.WriteLine(user);
            Console.WriteLine(new string('-', 50));
        }
    }
}