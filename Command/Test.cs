using NUnit.Framework;

namespace Command
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void CommandTest()
        {
            //TODO this is really incomplete, add example
            ICommand simpleCommand = new SimpleCommand();
            Assert.IsFalse(simpleCommand.WasExecuted);
            simpleCommand.Execute();
            Assert.IsTrue(simpleCommand.WasExecuted);
        }
    }
}
