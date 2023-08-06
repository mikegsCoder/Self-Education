namespace Education
{
    public class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Starting secondary education.");
        }

        public override void Study()
        {
            Console.WriteLine("Learning mathematics and literature.");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Getting document for finished secondary education.");
        }
    }
}
