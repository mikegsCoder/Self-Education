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

        }
    }
}