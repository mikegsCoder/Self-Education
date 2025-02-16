﻿using MongoDB.Bson;

namespace DataModels
{
    public class Person
    {
        public ObjectId Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public Company? Company { get; set; }

        public List<string>? Languages { get; set; } = new List<string>();
    }
}
