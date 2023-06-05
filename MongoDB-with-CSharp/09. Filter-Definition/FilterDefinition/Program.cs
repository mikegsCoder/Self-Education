using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;

namespace FilterDefinition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new string('-', 50);

            DatabaseOperations db = new DatabaseOperations("test2", "users");

            var builder1 = Builders<BsonDocument>.Filter;

            // Name == "Tom"
            var filter1 = builder1.Eq("Name", "Tom");

            // find with filter1:
            db.FindWithFilter(filter1);
            Console.WriteLine(separator);

            // Comparison Method:
            // Eq: equal
            // Ne: not equal
            // Gt: greater than
            // Gte: greater than or equal
            // Lt: less than
            // Lte: less than or equal
            // In: any of the values specified in an array
            // Nin: none of the values specified in an array

            // all documents, where Age > 33
            var filter2 = builder1.Gte("Age", 33);

            // find with filter2:
            db.FindWithFilter(filter2);
            Console.WriteLine(separator);

            // Age in { 33, 25 }
            var filter3 = builder1.In("Age", new int[] { 33, 25 });

            // find with filter3:
            db.FindWithFilter(filter3);
            Console.WriteLine(separator);

            var builder2 = Builders<Person>.Filter;

            var filter4 = builder2.Eq("Name", "Tom");

            // find with filter4:
            Console.WriteLine("Find POCO:");
            db.FindPersonsWithFilter(filter4);
            Console.WriteLine(separator);

            // Logical operations:
            // ! = Not
            // | = Or
            // & = And

            // Name == "Tom" or Age >= 33
            // var filter5 = builder1.Eq("Name", "Tom") | builder1.Gte("Age", 33);
            var filter5 = builder1.Or(builder1.Eq("Name", "Tom"), builder1.Gte("Age", 33));

            // find with filter5:
            db.FindWithFilter(filter5);
            Console.WriteLine(separator);

            // Name == "Tom" and Age >= 33
            var filter6 = builder1.Eq("Name", "Tom") & builder1.Gte("Age", 33);
            // var filter6 = builder1.And(builder1.Eq("Name", "Tom"), builder1.Gte("Age", 33));

            // find with filter6:
            db.FindWithFilter(filter6);
            Console.WriteLine(separator);

            // Age < 33 and Name != "Tom"
            var filter7 = !(builder1.Eq("Name", "Tom") | builder1.Gte("Age", 33));
            // var filter7 = builder1.Not(builder1.Or(builder1.Eq("Name", "Tom"), builder1.Gte("Age", 33)));

            // find with filter7:
            db.FindWithFilter(filter7);
            Console.WriteLine(separator);

            // Operations with elements - Exists / NotExists

            // Languages exists
            var filter8 = builder1.Exists("Languages");

            // find with filter8:
            db.FindWithFilter(filter8);
            Console.WriteLine(separator);

            // find with Regex:
            // Name ends with 'm'
            var filter9 = builder1.Regex("Name", new BsonRegularExpression("m$"));

            // find with filter9:
            db.FindWithFilter(filter9);
            Console.WriteLine(separator);

            // method Where():

            // Age < 30
            var filter10 = builder1.Where(d => d["Age"] < 30);

            // find with filter10:
            db.FindWithFilter(filter10);
            Console.WriteLine(separator);

            var filter11 = builder2.Where(p => p.Age < 30);

            // find with filter11:
            Console.WriteLine("Find POCO:");
            db.FindPersonsWithFilter(filter11);
            Console.WriteLine(separator);

            // Array operations:
            // All - documents, who contains all elements from the array
            // Size - documents, who has described size

            // Languages contains "english" and "spanish":
            var filter12 = builder1.All("Languages", new string[] { "english", "spanish" });

            // find with filter12:
            db.FindWithFilter(filter12);
            Console.WriteLine(separator);

            // Languages size == 1
            var filter13 = builder1.Size("Languages", 1);

            // find with filter13:
            db.FindWithFilter(filter13);
            Console.WriteLine(separator);
        }
    }
}