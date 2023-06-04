using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFiltration
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

        public void FindWithFilter(BsonDocument filter)
        {
            var users = collection.Find(filter);

            var usersList = users.ToList();

            foreach (var user in usersList)
            {
                Console.WriteLine(user);
            }
        }

        public void FindPersonsWithFilter(BsonDocument filter)
        {
            var personCollection = db.GetCollection<Person>("users");

            //using var cursor = await personCollection.FindAsync(new BsonDocument());
            //List<Person> users = cursor.ToList();

            var users = personCollection.Find(filter);

            var usersList = users.ToList();

            foreach (var user in usersList)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }
        }
    }
}
