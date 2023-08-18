namespace MathExpressions
{
    // terminal expression
    public class NumberExpression : IExpression
    {
        string name; // variable name

        public NumberExpression(string variableName)
        {
            name = variableName;
        }

        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
