namespace Interpreter
{
    public class MultiplyOperator : Operator
    {
        public MultiplyOperator(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            return (leftExpression ?? new ValueExpression(1)).Evaluate()
                * (rightExpression ?? new ValueExpression(1)).Evaluate();
        }
    }
}
