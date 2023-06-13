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

            WriteResult(collection);

            // update and delete:
            //await collection.BulkWriteAsync(new WriteModel<BsonDocument>[]
            collection.BulkWrite(new WriteModel<BsonDocument>[]
            {
                // update:
                new UpdateOneModel<BsonDocument>(new BsonDocument("Name", "Sam"), new BsonDocument("$set", new BsonDocument("Age", 30))),
                // replace:
                new ReplaceOneModel<BsonDocument>(new BsonDocument("Name", "Bob"), new BsonDocument{ {"Name", "Robert" }, {"Age", 44 } }),
                // delete:
                new DeleteOneModel<BsonDocument>(new BsonDocument("Name", "Alice"))
            });

            WriteResult(collection);

            // BulkWriteResult<TDocument> properties:
            //
            // Upserts: holds collection of added documents
            // InsertedCount: count of inserted documents
            // MatchedCount: count of matched documents
            // ModifiedCount: count of modified documents
            // DeletedCount: count of deleted documents

            //var result = await collection.BulkWriteAsync(new WriteModel<BsonDocument>[]
            var result = collection.BulkWrite(new WriteModel<BsonDocument>[]
            {
                new InsertOneModel<BsonDocument>(new BsonDocument{{"Name", "Alice"}, {"Age", 33 } }),
                new UpdateOneModel<BsonDocument>(new BsonDocument("Name", "Sam"), new BsonDocument("$set", new BsonDocument("Age", 32))),
                new ReplaceOneModel<BsonDocument>(new BsonDocument("Name", "Robert"), new BsonDocument("Name", "Bob")),
                new DeleteOneModel<BsonDocument>(new BsonDocument("Name", "Tom"))
            });

            Console.WriteLine($"Matched: {result.MatchedCount};  Inserted: {result.InsertedCount}; " +
                $"Modified: {result.ModifiedCount}; Deleted: {result.DeletedCount}");
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