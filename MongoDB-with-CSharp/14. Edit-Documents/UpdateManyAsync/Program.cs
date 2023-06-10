using MongoDB.Bson;
using MongoDB.Driver;

namespace UpdateManyAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            // increment Age by 1 where Name == "Tom":
            //var result1 = await collection.UpdateManyAsync(
            //    new BsonDocument("Name", "Tom"),
            //    new BsonDocument("$inc", new BsonDocument("Age", 1)));
            var result1 = collection.UpdateMany(
                new BsonDocument("Name", "Tom"),
                new BsonDocument("$inc", new BsonDocument("Age", 1)));

            WriteResult(collection, result1);

            // UpdateDefinitionBuilder methods:
            //
            // Set: set field value
            // AddToSet: add new elements into array: Builders<BsonDocument>.Update.AddToSet("Languages", "spanish")
            // Inc: increment value: Builders<BsonDocument>.Update.Inc("Age", 2)
            // Mul: multiply
            // Push: push elements into array: Builders<BsonDocument>.Update.Push("Languages", "french")
            // Pull: remove from array: Builders<BsonDocument>.Update.Pull("Languages", "french")
            // Unset: remove field from document: Builders<BsonDocument>.Update.Unset("Age")
            // PopFirst: select first element from array
            // PopLast: select last element from array
            // Rename: rename field: Builders<BsonDocument>.Update.Rename("Age", "Year");.

            // set filter 
            var filter2 = Builders<BsonDocument>.Filter.Eq("Name", "Tom");
            // set update
            var update2 = Builders<BsonDocument>.Update.Set("Age", 30);
            //var result1 = await collection.UpdateManyAsync(filter2, update2);
            var result2 = collection.UpdateMany(filter2, update2);

            WriteResult(collection, result2);

            // set update date:
            var filter3 = Builders<BsonDocument>.Filter.Eq("Name", "Tom");
            var update3 = Builders<BsonDocument>.Update.Set("Age", 33).CurrentDate("LastModified");
            //var result3 = await collection.UpdateManyAsync(filter3, update3);
            var result3 = collection.UpdateMany(filter3, update3);

            WriteResult(collection, result3);
        }

        private static void WriteResult(IMongoCollection<BsonDocument> collection, UpdateResult result)
        {
            Console.WriteLine($"Matched: {result.MatchedCount}; Modified: {result.ModifiedCount}");

            var users = collection.Find("{}").ToList();
            foreach (var user in users) Console.WriteLine(user);
            Console.WriteLine(new string('-', 50));
        }
    }
}