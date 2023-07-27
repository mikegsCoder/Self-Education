namespace Programmers
{
    public class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Using C++ compiller to create binary code.");
        }

        public void Execute()
        {
            Console.WriteLine("Executing binary code.");
        }
    }
}
