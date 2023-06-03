using MongoDB.Bson;
using MongoDB.Driver;

namespace FindDocumentsFromDB
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

        public void Find()
        {
            var users = collection.Find(new BsonDocument());

            var usersList = users.ToList();

            foreach (var user in usersList)
            {
                Console.WriteLine(user);
            }
        }

        public async void FindAsync()
        {
            using var cursor = await collection.FindAsync(new BsonDocument());
            
            List<BsonDocument> users = cursor.ToList();

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        public void FindPersons()
        {
            var personCollection = db.GetCollection<Person>("users");

            //using var cursor = await personCollection.FindAsync(new BsonDocument());
            //List<Person> users = cursor.ToList();

            var users = personCollection.Find(new BsonDocument());

            var usersList = users.ToList();

            foreach (var user in usersList)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }
        }

        public async void GetCount()
        {
            long count = await collection.CountDocumentsAsync(new BsonDocument());
            Console.WriteLine("Collection count: " + count);
        }

        public void InsertOne(BsonDocument document)
        {
            //await collection.InsertOneAsync(document);
            collection.InsertOne(document);
        }

        public async void InsertMany(List<BsonDocument> list)
        {
            await collection.InsertManyAsync(list);
        }
    }
}
