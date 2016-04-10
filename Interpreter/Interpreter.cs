namespace Interpreter
{
    public class Interpreter
    {
        public int Evaluate(IExpression expression)
        {
            return expression.Evaluate();
        }
    }
}
