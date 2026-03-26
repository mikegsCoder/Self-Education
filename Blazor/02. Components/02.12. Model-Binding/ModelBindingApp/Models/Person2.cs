namespace ModelBindingApp.Models
{
    public class Person2
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public DateTime Day { get; set; } = DateTime.Now;
        public bool Working { get; set; }
        public string Subject { get; set; } = "";
        public string[] Courses { get; set; } = [];
    }
}
