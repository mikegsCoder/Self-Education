using MongoDB.Bson;
using MongoDB.Driver;

namespace UpdateAndPOCO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<Person>("users");

            // set f1lter:
            var filter = Builders<Person>.Filter.Eq(p => p.Name, "Tom");

            // set update:
            //var update = Builders<Person>.Update.Set(p => p.Age, 34);
            //var update = Builders<Person>.Update.Set(p => p.Age, 35)
            //  .Set(p => p.LastModified, DateTime.Now);
            var update = Builders<Person>.Update
                .Set(p => p.Age, 35)
                .Set(p => p.Languages, new List<string>() { "new language" })
                .Set(p => p.LastModified, DateTime.Now);

            // update:
            //var result = await collection.UpdateManyAsync(filter, update);
            var result = collection.UpdateMany(filter, update);

            Console.WriteLine($"Matched: {result.MatchedCount}; Updated: {result.ModifiedCount}");

            var users = collection.Find("{}").ToList();
            foreach (var user in users) Console.WriteLine(user.ToJson());
        }
    }
}