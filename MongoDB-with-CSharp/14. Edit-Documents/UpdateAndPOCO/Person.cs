using MongoDB.Bson;

namespace UpdateAndPOCO
{
    internal class Person
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }

        public List<string>? Languages { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
