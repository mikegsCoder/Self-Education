using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; } = "";

        public List<string>? Languages { get; set; }
    }
}
