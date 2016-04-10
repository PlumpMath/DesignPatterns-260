namespace Interpreter
{
    public abstract class Operator : IExpression
    {
        protected readonly IExpression leftExpression;
        protected readonly IExpression rightExpression;

        public Operator(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public abstract int Evaluate();
    }
}
