using MongoDB.Bson;
using MongoDB.Driver;

namespace UsingCSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            var collection = db.GetCollection<Employee>("employees");

            // group by company title and get list with employee names:
            //var companies = await collection.Aggregate()
            //    .Group(emp => emp.Company!.Title,   // group by company title
            //    g => new CompanyModel               // create new CompanyModel
            //    {
            //        CompanyName = g.Key,
            //        Employees = g.Select(e => e.Name).ToList() // select employee name into list
            //    })
            //    .ToListAsync();
            var companies1 = collection.Aggregate()
                .Group(emp => emp.Company!.Title,   // group by company title
                g => new CompanyModel               // create new CompanyModel
                {
                    CompanyName = g.Key,
                    Employees = g.Select(e => e.Name).ToList() // select employee name into list
                })
                .ToList();

            foreach (var company in companies1)
            {
                Console.WriteLine(company.CompanyName);

                foreach (var employeeName in company.Employees)
                    Console.WriteLine(employeeName);

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 50));

            // group by company title and create anonymous object:
            //var companies2 = await collection.Aggregate()
            //.Group(emp => emp.Company!.Title,   // group by company title
            //g => new                            // create anonymous object
            //{
            //    CompanyName = g.Key,
            //    Employees = g.Select(e => e.Name).ToList(), // get list with employee names
            //    SumAge = g.Sum(e => e.Age),
            //    MinAge = g.Min(e => e.Age),
            //    MaxAge = g.Max(e => e.Age),
            //    AvgAge = g.Average(e => e.Age),
            //    First = g.First().Name,
            //    Lass = g.Last().Name
            //})
            //.ToListAsync();
            var companies2 = collection.Aggregate()
            .Group(emp => emp.Company!.Title,   // group by company title
            g => new                            // create anonymous object
            {
                CompanyName = g.Key,
                Employees = g.Select(e => e.Name).ToList(), // get list with employee names
                SumAge = g.Sum(e => e.Age),
                MinAge = g.Min(e => e.Age),
                MaxAge = g.Max(e => e.Age),
                AvgAge = g.Average(e => e.Age),
                First = g.First().Name,
                Lass = g.Last().Name
            })
            .ToList();

            foreach (var company in companies2)
            {
                Console.WriteLine(company.ToJson());
            }

            Console.WriteLine(new string('-', 50));
        }
    }

    class CompanyModel
    {
        public string CompanyName { get; set; } = "";
        public List<string> Employees { get; set; } = new();
    }

    record Employee(ObjectId Id, string Name, int Age, Company? Company);

    record Company(string Title);
}