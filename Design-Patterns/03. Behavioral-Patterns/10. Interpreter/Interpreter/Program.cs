namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            var expression = new NonterminalExpression();
            expression.Interpret(context);
        }
    }
}