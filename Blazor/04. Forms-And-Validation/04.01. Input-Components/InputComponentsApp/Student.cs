namespace InputComponentsApp
{
    public class Student
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; } = DateTime.Now; 
        public bool HasWork { get; set; }
        public string Subject { get; set; } = "";
        public string[] Courses { get; set; } = [];
    }
}
