using MongoDB.Bson;
using MongoDB.Driver;

namespace MethodBulkWriteAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("people");

            // add new document:
            //await collection.BulkWriteAsync(new WriteModel<BsonDocument>[]
            collection.BulkWrite(new WriteModel<BsonDocument>[]
            {
                new InsertOneModel<BsonDocument>(new BsonDocument{{"Name", "Tom"}, {"Age", 38 } })
            });

            WriteResult(collection);

            // add many documents:
            //await collection.BulkWriteAsync(new WriteModel<BsonDocument>[]
            collection.BulkWrite(new WriteModel<BsonDocument>[]
            {
                new InsertOneModel<BsonDocument>(new BsonDocument{{"Name", "Sam"}, {"Age", 28 } }),
                new InsertOneModel<BsonDocument>(new BsonDocument{{"Name", "Bob"}, {"Age", 42 } }),
                new InsertOneModel<BsonDocument>(new BsonDocument{{"Name", "Alice"}, {"Age", 33 } })
            });
        }

        private static void WriteResult(IMongoCollection<BsonDocument> collection)
        {
            Console.WriteLine("After BulkWrite:");

            var people = collection.Find("{}").ToList();

            foreach (var person in people) Console.WriteLine(person);

            Console.WriteLine(new string('-', 50));
        }
    }
}