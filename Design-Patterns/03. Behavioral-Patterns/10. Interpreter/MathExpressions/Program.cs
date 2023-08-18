namespace MathExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            // set variables
            int x = 5;
            int y = 8;
            int z = 2;

            // add variables into the context
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);

            // create object fot calculation expression: x + y - z
            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("x"),
                    new NumberExpression("y")),
                new NumberExpression("z")
            );

            int result = expression.Interpret(context);
            Console.WriteLine("Result: {0}", result);

            Console.Read();
        }
    }
}