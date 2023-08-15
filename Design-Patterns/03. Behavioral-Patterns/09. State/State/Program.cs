namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new StateA());

            context.Request(); // change state to StateB
            context.Request(); // change state to StateA
        }
    }
}