namespace Education
{
    public abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }

        public abstract void Enter();

        public abstract void Study();

        public virtual void PassExams()
        {
            Console.WriteLine("Passing exams.");
        }

        public abstract void GetDocument();
    }
}
