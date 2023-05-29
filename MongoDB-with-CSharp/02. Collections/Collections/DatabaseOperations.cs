using MongoDB.Bson;
using MongoDB.Driver;

namespace Collections
{
    public class DatabaseOperations
    {
        private MongoClient client;
        private IMongoDatabase db;

        public DatabaseOperations(string _databaseName)
        {
            client = new MongoClient("mongodb://localhost:27017");

            db = client.GetDatabase(_databaseName);
        }

        public async void GetCollections()
        {
            var collections = await db.ListCollections().ToListAsync();

            if (collections.Count == 0)
            {
                await Console.Out.WriteLineAsync("No collections in database!");
            }
            else
            {
                foreach (var collection in collections)
                {
                    Console.WriteLine(collection);
                }
            }
        }

        public async void GetCollectionNames()
        {
            var collectionNames = await db.ListCollectionNames().ToListAsync();

            if (collectionNames.Count == 0)
            {
                await Console.Out.WriteLineAsync("No collections in database!");
            }
            else
            {
                foreach (var name in collectionNames)
                {
                    Console.WriteLine(name);
                }
            }
        }

        public async void CreateCollection(string name)
        {
            await db.CreateCollectionAsync(name);
        }

        public async void RenameCollection(string oldName, string newName)
        {
            await db.RenameCollectionAsync(oldName, newName);
        }

        public async void DropCollection(string name)
        {
            await db.DropCollectionAsync(name);
        }

        public IMongoCollection<BsonDocument> GetCollection(string name)
        {
            return db.GetCollection<BsonDocument>(name);
        }
    }
}
