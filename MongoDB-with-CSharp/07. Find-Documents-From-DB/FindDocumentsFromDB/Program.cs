using MongoDB.Bson;

namespace FindDocumentsFromDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new String('-', 50);

            DatabaseOperations db = new DatabaseOperations("test2", "users");

            BsonDocument tom = new BsonDocument
            {
                {"Name", "Tom"},
                {"Age", 38}
            };

            // insert one:
            db.InsertOne(tom);

            BsonDocument bob = new BsonDocument { { "Name", "Bob" }, { "Age", 42 } };
            BsonDocument sam = new BsonDocument { { "Name", "Sam" }, { "Age", 25 } };

            // insert many:
            db.InsertMany(new List<BsonDocument> { bob, sam });

            // find:
            db.Find();
            Console.WriteLine(separator);

            // find async:
            db.FindAsync();
            Console.WriteLine(separator);

            // find persons:
            db.FindPersons();
            Console.WriteLine(separator);

            // count:
            db.GetCount();
            Console.WriteLine(separator);
        }
    }
}