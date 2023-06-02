using MongoDB.Bson;

namespace InsertDocumentsIntoDB
{
    // POCO:
    public class Person
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }
    }
}
