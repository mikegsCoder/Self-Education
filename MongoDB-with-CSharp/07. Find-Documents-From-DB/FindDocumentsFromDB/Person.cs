using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FindDocumentsFromDB
{
    [BsonIgnoreExtraElements]
    public class Person
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }
    }
}
