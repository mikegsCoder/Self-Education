using MongoDB.Bson;

namespace DataFiltration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new string('-', 50);

            DatabaseOperations db = new DatabaseOperations("test2", "users");

            var filter1 = new BsonDocument { { "Name", "Tom" } };

            // find with filter1:
            db.FindWithFilter(filter1);
            Console.WriteLine(separator);

            var filter2 = new BsonDocument { { "Name", "Tom" }, { "Age", 38 } };

            // find with filter2:
            db.FindWithFilter(filter2);
            Console.WriteLine(separator);

            // Comparison Method:
            // $eq(equal)
            // $ne(not equal)
            // $gt(greater than)
            // $lt(less than)
            // $gte(greater than or equal)
            // $lte(less than or equal)
            // $in (any of the values specified in an array)
            // $nin (none of the values specified in an array)

            // all documents, where Name != "Tom"
            var filter3 = new BsonDocument { { "Name", new BsonDocument("$ne", "Tom") } };

            // find with filter3:
            db.FindWithFilter(filter3);
            Console.WriteLine(separator);

            // all documents, where Age > 33
            var filter4 = new BsonDocument { { "Age", new BsonDocument("$gt", 33) } };

            // find with filter4:
            db.FindWithFilter(filter4);
            Console.WriteLine(separator);

            // Age > 33 && Name != "Tom"
            var filter5 = new BsonDocument { { "Age", new BsonDocument("$gt", 33) }, { "Name", new BsonDocument("$ne", "Tom") } };

            // find with filter5:
            db.FindWithFilter(filter5);
            Console.WriteLine(separator);

            // Age in {33, 25}
            var filter6 = new BsonDocument { { "Age", new BsonDocument("$in", new BsonArray { 33, 25 }) } };

            // find with filter6:
            db.FindWithFilter(filter6);
            Console.WriteLine(separator);

            // Logical operators:
            // $or: OR
            // $and: AND
            // $not: NOT
            // $nor: NOR

            // Age >= 33 OR Name == "Tom"
            var filter7 = new BsonDocument("$or", new BsonArray
            {
                new BsonDocument("Age",new BsonDocument("$gte", 40)),
                new BsonDocument("Name", "Tom")
            });

            // find with filter7:
            db.FindWithFilter(filter7);
            Console.WriteLine(separator);

            // Age >= 33 AND Name == "Tom"
            var filter8 = new BsonDocument("$and", new BsonArray
            {
                new BsonDocument("Age",new BsonDocument("$gte", 33)),
                new BsonDocument("Name", "Tom")
            });

            // find with filter8:
            db.FindWithFilter(filter8);
            Console.WriteLine(separator);

            // all documents, where Languages is not null
            var filter9 = new BsonDocument("Languages", new BsonDocument { { "$ne", BsonNull.Value } });

            // find with filter9:
            db.FindWithFilter(filter9);
            Console.WriteLine(separator);

            // all documents, where Languages exists
            var filter10 = new BsonDocument("Languages", new BsonDocument { { "$exists", true } });

            // find with filter10:
            db.FindWithFilter(filter10);
            Console.WriteLine(separator);

            // all documents, where Languages dos not exist
            var filter11 = new BsonDocument("Languages", new BsonDocument { { "$exists", false } });

            // find with filter11:
            db.FindWithFilter(filter11);
            Console.WriteLine(separator);

            // Find in array
            // $all: documents if the array field contains every element specified in the query
            // $size: documents if the array field is a specified number of elements
            // $elemMatch: documents if an element in the array field matches all the specified conditions

            // array Languages nust have all described elements
            var filter12 = new BsonDocument("Languages", new BsonDocument { { "$all", new BsonArray { "english", "spanish" } } });

            // find with filter12:
            db.FindWithFilter(filter12);
            Console.WriteLine(separator);

            // array Languages must have only 1 element
            var filter13 = new BsonDocument("Languages", new BsonDocument { { "$size", 1 } });

            // find with filter13:
            db.FindWithFilter(filter13);
            Console.WriteLine(separator);

            // Name must end with letter 'm'
            var filter14 = new BsonDocument("Name", new BsonDocument { { "$regex", "m$" } });

            // find with filter14:
            db.FindWithFilter(filter14);
            Console.WriteLine(separator);

            // find POCO where Name == "Tom"
            var filter15 = new BsonDocument("Name", "Tom");

            // find with filter15:
            Console.WriteLine("Find POCO:");
            db.FindWithFilter(filter15);
            Console.WriteLine(separator);
        }
    }
}