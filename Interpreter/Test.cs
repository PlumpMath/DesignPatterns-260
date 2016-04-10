using NUnit.Framework;

namespace Interpreter
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void InterpreterTest()
        {
            var expression1 = new DivideOperator(new ValueExpression(8), new ValueExpression(2));
            var expression2 = new MultiplyOperator(new ValueExpression(2), new ValueExpression(3));
            var expression3 = new AddOperation(expression1, expression2);

            var interpreter = new Interpreter();

            Assert.AreEqual(4, interpreter.Evaluate(expression1));
            Assert.AreEqual(6, interpreter.Evaluate(expression2));
            Assert.AreEqual(10, interpreter.Evaluate(expression3));
        }
    }
}
