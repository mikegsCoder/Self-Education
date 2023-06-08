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
