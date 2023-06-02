using MongoDB.Bson;
using MongoDB.Driver;

namespace InsertDocumentsIntoDB
{
    public class DatabaseOperations
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;

        public DatabaseOperations(string _databaseName, string _collection)
        {
            client = new MongoClient("mongodb://localhost:27017");

            db = client.GetDatabase(_databaseName);

            collection = db.GetCollection<BsonDocument>(_collection);
        }
        
        public async void InsertOne( BsonDocument document)
        {
            await collection.InsertOneAsync(document);
        }

        public async void InsertMany(List<BsonDocument> list)
        {
            await collection.InsertManyAsync(list);
        }

        public async void InsertPoco(Person person)
        {
            var users = db.GetCollection<Person>("users");

            await users.InsertOneAsync(person);
        }
    }
}
