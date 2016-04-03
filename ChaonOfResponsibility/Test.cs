using NUnit.Framework;

namespace ChaonOfResponsibility
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ChainOfResponsibilityTest()
        {
            var request = new Request();

            var bottomHandler = new BottomHandler();
            var topHandler = new TopHandler(bottomHandler);

            topHandler.Handle(request);

            Assert.True(request.HandledBy.Contains(bottomHandler));
            Assert.True(request.HandledBy.Contains(topHandler));
        }
    }
}
