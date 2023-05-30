using MongoDB.Bson;

namespace Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new String('-', 50);

            BsonElement el = new BsonElement("name", new BsonString("Tom"));

            Console.WriteLine(el);       // name = Tom
            Console.WriteLine(el.Name);  // name
            Console.WriteLine(el.Value); // Tom

            Console.WriteLine(separator);

            BsonElement nameElement = new BsonElement("name", "Tom");
            BsonElement ageElement = new BsonElement("age", 38);

            Console.WriteLine(nameElement); // name = Tom 
            Console.WriteLine(ageElement);  // age = 38

            Console.WriteLine(separator);
        }
    }
}