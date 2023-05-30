using MongoDB.Bson;

namespace Documents
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string separator = new String('-', 50);

            BsonElement name = new BsonElement("name", "Tom");
            BsonDocument doc1 = new BsonDocument(name);

            Console.WriteLine(doc1); // { "name" : "Tom" }

            Console.WriteLine(separator);

            BsonDocument doc2 = new BsonDocument
            {
                {"name","Tom"},
                {"age", 38},
                {"company", new BsonDocument{{"name" , "microsoft"}}},
                {"languages", new BsonArray{"english", "german", "spanish" } }
            };

            Console.WriteLine(doc2);

            Console.WriteLine(separator);

            // get value element name:
            Console.WriteLine(doc2["name"]);      // Tom
            // get value element languages:
            Console.WriteLine(doc2["languages"]); // [english, german, spanish]

            // edit valie element age:
            doc2["age"] = 22;
            Console.WriteLine(doc2["age"]);       // 22

            Console.WriteLine(separator);

            BsonDocument doc3 = new BsonDocument { { "name", "Bob" } };

            BsonElement email = new BsonElement("email", "bob@localhost.com");
            // add element email:
            doc3.Add(email);

            Console.WriteLine(doc3); // { "name" : "Bob", "email" : "bob@localhost.com" }

            // remove element name:
            doc3.Remove("name");

            Console.WriteLine(doc3); // { "email" : "bob@localhost.com" }

            Console.WriteLine(separator);
        }
    }
}