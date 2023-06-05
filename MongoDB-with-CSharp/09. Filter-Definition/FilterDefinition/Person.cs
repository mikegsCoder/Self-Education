using MongoDB.Bson;

namespace FilterDefinition
{
    public class Person
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }

        public List<string>? Languages { get; set; }
    }
}
