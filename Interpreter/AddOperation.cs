namespace Interpreter
{
    public class AddOperation : Operator
    {
        public AddOperation(IExpression leftExpression, IExpression rightExpression)
            : base(leftExpression, rightExpression)
        {
        }

        public override int Evaluate()
        {
            return leftExpression.Evaluate() + rightExpression.Evaluate();
        }
    }
}
