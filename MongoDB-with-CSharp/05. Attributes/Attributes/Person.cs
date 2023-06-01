using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class Person
    {
        [BsonId]
        public int PersonId { get; set; }

        [BsonElement("Login")]
        public string Name { get; set; } = "";

        [BsonIgnore]
        public string Email { get; set; } = "";

        [BsonIgnoreIfDefault]
        [BsonRepresentation(BsonType.String)]
        public int Age { get; set; }

        [BsonIgnoreIfNull]
        public Company? Company { get; set; }
    }
}
