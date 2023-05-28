using MongoDB.Driver;

namespace MongoDbApp
{
    public class DatabaseOperations
    {
        private MongoClient client; 

        public DatabaseOperations() 
        { 
            client = new MongoClient("mongodb://localhost:27017");
        }

        public async void GetDatabases()
        {
            using (var cursor = client.ListDatabases())
            {
                var databases = await cursor.ToListAsync();

                foreach (var database in databases)
                {
                    Console.WriteLine(database.ToString());
                }
            }
        }

        public async void GetDatabaseNames()
        {
            using (var cursor = client.ListDatabaseNames())
            {
                var databasesNames = await cursor.ToListAsync();

                foreach (var name in databasesNames)
                {
                    Console.WriteLine(name);
                }
            }
        }

        public void GetDatabase(string name)
        {
            client.GetDatabase(name);
        }

        public async void DropDatabase(string name)
        {
            await client.DropDatabaseAsync(name);
        }
    }
}
