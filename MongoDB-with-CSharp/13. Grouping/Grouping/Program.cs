using MongoDB.Bson;
using MongoDB.Driver;

namespace Grouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new string('-', 50);

            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<BsonDocument>("employees");

            // group by company title:
            //var employees = await collection.Aggregate()
            //    .Group(new BsonDocument {
            //        { "_id", "$Company.Title" },               // grouping by company title
            //        { "count", new BsonDocument("$sum", 1) },  // get documents count in the group
            //    })
            //    .ToListAsync();
            var employees1 = collection.Aggregate()
                .Group(new BsonDocument {
                    { "_id", "$Company.Title" },               // grouping by company title
                    { "count", new BsonDocument("$sum", 1) },  // get documents count in the group
                })
                .ToList();

            foreach (var employeeGroup in employees1) Console.WriteLine(employeeGroup);
            Console.WriteLine(separator);

            // group by company title and get min, max and average Age:
            //var employees2 = await collection.Aggregate()
            //    .Group(new BsonDocument {
            //        { "_id", "$Company.Title" },
            //        { "minAge", new BsonDocument("$min", "$Age") },
            //        { "maxAge", new BsonDocument("$max", "$Age") },
            //        { "avgAge", new BsonDocument("$avg", "$Age") }
            //    })
            //    .ToListAsync();
            var employees2 = collection.Aggregate()
                .Group(new BsonDocument {
                    { "_id", "$Company.Title" },
                    { "minAge", new BsonDocument("$min", "$Age") },
                    { "maxAge", new BsonDocument("$max", "$Age") },
                    { "avgAge", new BsonDocument("$avg", "$Age") }
                })
                .ToList();

            foreach (var employeeGroup in employees2) Console.WriteLine(employeeGroup);
            Console.WriteLine(separator);

            // group by company title ang get Name of the first and last employee in the group:
            //var employees3 = await collection.Aggregate()
            //    .Group(new BsonDocument {
            //        { "_id", "$Company.Title" },
            //        { "first", new BsonDocument("$first", "$Name") },
            //        { "last", new BsonDocument("$last", "$Name") }
            //    })
            //    .ToListAsync();
            var employees3 = collection.Aggregate()
                .Group(new BsonDocument {
                    { "_id", "$Company.Title" },
                    { "first", new BsonDocument("$first", "$Name") },
                    { "last", new BsonDocument("$last", "$Name") }
                })
                .ToList();

            foreach (var employeeGroup in employees3) Console.WriteLine(employeeGroup);
            Console.WriteLine(separator);

            // group by company title and get array with the names of the employees:
            //var employees4 = await collection.Aggregate()
            //.Group(new BsonDocument {
            //    { "_id", "$Company.Title" },
            //    { "employees", new BsonDocument("$push", "$Name") } })
            //.ToListAsync();
            var employees4 = collection.Aggregate()
            .Group(new BsonDocument {
                { "_id", "$Company.Title" },
                { "employees", new BsonDocument("$push", "$Name") } })
            .ToList();

            foreach (var employeeGroup in employees4) Console.WriteLine(employeeGroup);
            Console.WriteLine(separator);
        }
    }
}