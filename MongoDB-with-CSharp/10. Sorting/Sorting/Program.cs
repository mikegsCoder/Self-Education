using MongoDB.Bson;
using MongoDB.Driver;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BsonDocument> users1;
            List<Person> users2;
            string separator = new string('-', 50);

            DatabaseOperations db = new DatabaseOperations("test2", "users");

            // sort by Age ascending:
            users1 = db.FindWithFilter(new BsonDocument { })
                .Sort(new BsonDocument("Age", 1))
                .ToList();
            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

            // sort by Age ascending:
            users1 = db.FindWithFilter(new BsonDocument { })
                .Sort("{Age:1}")
                .ToList();
            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

            // sort by Age descending:
            users1 = db.FindWithFilter(new BsonDocument { })
                .Sort(new BsonDocument("Age", -1))
                .ToList();
            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

            // sort by Name ascending:
            users1 = db.FindWithFilter(new BsonDocument { })
                .SortBy(d => d["Name"])
                .ToList();

            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

            // sort by Name descending:
            users1 = db.FindWithFilter(new BsonDocument { })
                .SortByDescending(d => d["Name"])
                .ToList();

            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

            // sort POCO by Name ascending:
            users2 = db.FindPersonsWithFilter(new BsonDocument { })
                .SortBy(p => p.Name)
                .ToList();

            foreach (var user in users2) Console.WriteLine($"{user.Name} - {user.Age}");
            Console.WriteLine(separator);

            // multiple sort criteria:
            var sortDefinition1 = Builders<BsonDocument>.Sort.Ascending("Name").Descending("Age");
            
            users1 = db.FindWithFilter(new BsonDocument { })
                .Sort(sortDefinition1)
                .ToList();

            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);

            // multiple sort criteria for POCO:
            var sortDefinition2 = Builders<Person>.Sort.Ascending(p => p.Name).Descending(p => p.Age);
            
            users2 = db.FindPersonsWithFilter(new BsonDocument { })
                .Sort(sortDefinition2)
                .ToList();

            foreach (var user in users2) Console.WriteLine($"{user.Name} - {user.Age}");
            Console.WriteLine(separator);

            // multiple sort criteria:
            users1 = db.FindWithFilter(new BsonDocument { })
                .Sort("{Name:1, Age:-1}")
                .ToList();

            foreach (var user in users1) Console.WriteLine(user);
            Console.WriteLine(separator);
        }
    }
}