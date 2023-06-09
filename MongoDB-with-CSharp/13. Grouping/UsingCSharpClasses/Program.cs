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