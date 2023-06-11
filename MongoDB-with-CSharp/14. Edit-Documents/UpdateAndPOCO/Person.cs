using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
