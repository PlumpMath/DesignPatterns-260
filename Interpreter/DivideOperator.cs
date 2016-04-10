namespace Interpreter
{
    public class DivideOperator : Operator
    {
        public DivideOperator(IExpression leftExpression, IExpression rightExpression)
            : base(leftExpression, rightExpression)
        {
        }

        public override int Evaluate()
        {
            return leftExpression.Evaluate() / rightExpression.Evaluate();
        }
    }
}
