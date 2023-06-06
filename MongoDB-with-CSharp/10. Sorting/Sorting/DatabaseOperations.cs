using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
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

        public IFindFluent<BsonDocument, BsonDocument> FindWithFilter(BsonDocument filter)
        {
            var users = collection.Find(filter);

            return users;
        }

        public IFindFluent<Person, Person> FindPersonsWithFilter(BsonDocument filter)
        {
            var personCollection = db.GetCollection<Person>("users");

            var users = personCollection.Find(filter);

            return users;
        }
    }
}
