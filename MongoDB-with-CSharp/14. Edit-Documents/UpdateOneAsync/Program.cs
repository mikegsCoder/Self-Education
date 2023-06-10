using MongoDB.Bson;
using MongoDB.Driver;

namespace UpdateOneAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("users");

            // set filter - document, where Name = Tom:
            var filter1 = new BsonDocument("Name", "Tom");

            // set update parameters - update only field Age:
            var updateSettings1 = new BsonDocument("$set", new BsonDocument("Age", 39));
            
            // execute update:
            //var result1 = await collection.UpdateOneAsync(filter1, updateSettings1);
            var result1 = collection.UpdateOne(filter1, updateSettings1);

            WriteResult(collection, result1);

            // update Name and Age:
            var filter2 = new BsonDocument("Name", "Tomas");
            var updateSettings2 = new BsonDocument("$set", new BsonDocument { { "Name", "Tom" }, { "Age", 33 } });
            //var result2 = await collection.UpdateOneAsync(filter, updateSettings);
            var result2 = collection.UpdateOne(filter2, updateSettings2);

            WriteResult(collection, result2);

            // increment Age by 2:
            //var result3 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Bob"),
            //    new BsonDocument("$inc", new BsonDocument("Age", 2)));
            var result3 = collection.UpdateOne(
                new BsonDocument("Name", "Bob"),
                new BsonDocument("$inc", new BsonDocument("Age", 2)));

            WriteResult(collection, result3);

            // remove field Age where Name == "Alexander":
            //var result4 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Alexander"),
            //    new BsonDocument("$unset", new BsonDocument("Age", 1)));
            var result4 = collection.UpdateOne(
                new BsonDocument("Name", "Alexander"),
                new BsonDocument("$unset", new BsonDocument("Age", 1)));
            
            WriteResult(collection, result4);

            // push "english" into "Languages" array where Name == "Sam":
            //var result5 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Sam"),
            //    new BsonDocument("$push", new BsonDocument { { "Languages", "english" } }));
            var result5 = collection.UpdateOne(
                new BsonDocument("Name", "Sam"),
                new BsonDocument("$push", new BsonDocument { { "Languages", "english" } }));
            
            WriteResult(collection, result5);

            // push "french" and "german" into "Languages" array where Name == "Sam":
            //var result6 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Sam"),
            //    new BsonDocument("$push",
            //            new BsonDocument("Languages",
            //                new BsonDocument("$each", new BsonArray { "french", "german" }))));
            var result6 = collection.UpdateOne(
                new BsonDocument("Name", "Sam"),
                new BsonDocument("$push",
                        new BsonDocument("Languages",
                            new BsonDocument("$each", new BsonArray { "french", "german" }))));

            WriteResult(collection, result6);

            // add "italian" into "Languages" array where Name == "Sam":
            //var result7 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Sam"),
            //    new BsonDocument("$addToSet", new BsonDocument("Languages", "italian")));
            var result7 =  collection.UpdateOne(
                new BsonDocument("Name", "Sam"),
                new BsonDocument("$addToSet", new BsonDocument("Languages", "italian")));

            WriteResult(collection, result7);

            // remove first element from the end of the "Languages" array:
            //var result8 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Sam"),
            //    new BsonDocument("$pop", new BsonDocument("Languages", 1)));
            var result8 = collection.UpdateOne(
                new BsonDocument("Name", "Sam"),
                new BsonDocument("$pop", new BsonDocument("Languages", 1)));

            WriteResult(collection, result8);

            // remove first element from the beginning of the "Languages" array:
            //var result9 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Sam"),
            //    new BsonDocument("$pop", new BsonDocument("Languages", -1)));
            var result9 = collection.UpdateOne(
                new BsonDocument("Name", "Sam"),
                new BsonDocument("$pop", new BsonDocument("Languages", -1)));

            WriteResult(collection, result9);

            // remove all "german" elements from the "Languages" array:
            //var result10 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Sam"),
            //    new BsonDocument("$pull", new BsonDocument("Languages", "german")));
            var result10 = collection.UpdateOne(
                new BsonDocument("Name", "Sam"),
                new BsonDocument("$pull", new BsonDocument("Languages", "german")));

            WriteResult(collection, result10);

            // remove all "english" and "french" elements from the "Languages" array:
            //var result11 = await collection.UpdateOneAsync(
            //    new BsonDocument("Name", "Sam"),
            //    new BsonDocument("$pullAll", new BsonDocument("Languages", new BsonArray { "english", "french" })));
            var result11 = collection.UpdateOne(
                new BsonDocument("Name", "Sam"),
                new BsonDocument("$pullAll", 
                    new BsonDocument("Languages", 
                        new BsonArray { "english", "french" })));

            WriteResult(collection, result11);
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