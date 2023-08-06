namespace Education
{
    public class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Taking exams to enter into University.");
        }

        public override void Study()
        {
            Console.WriteLine("Learning software development concepts.");
            Console.WriteLine("Developing projects.");
        }

        public override void PassExams()
        {
            Console.WriteLine("Passing project defence.");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Getting diploma for software developer.");
        }
    }
}
