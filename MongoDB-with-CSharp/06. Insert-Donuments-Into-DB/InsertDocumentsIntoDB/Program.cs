using MongoDB.Bson;
using MongoDB.Driver;

namespace InsertDocumentsIntoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DatabaseOperations db = new DatabaseOperations("test2", "users");

            BsonDocument tom = new BsonDocument
            {
                {"Name", "Tom"},
                {"Age", 38}
            };

            // insert one:
            db.InsertOne(tom);

            Console.WriteLine(tom);
            Console.WriteLine(new String('-', 50));

            BsonDocument bob = new BsonDocument { { "Name", "Bob" }, { "Age", 42 } };
            BsonDocument sam = new BsonDocument { { "Name", "Sam" }, { "Age", 25 } };

            // insert many:
            db.InsertMany(new List<BsonDocument> { bob, sam });

            Console.WriteLine(bob);
            Console.WriteLine(sam);
            Console.WriteLine(new String('-', 50));

            // insert POCO:
            Person alice = new Person { Name = "Alice", Age = 33 };

            db.InsertPoco(alice);

            Console.WriteLine(alice.Id);
            Console.WriteLine(new String('-', 50));
        }
    }
}