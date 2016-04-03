using NUnit.Framework;

namespace Adapter
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void AdapterTest()
        {
            var client = new SimpleClient();
            Assert.IsFalse(client.IsConnected);

            client.SimpleConnect();

            Assert.IsTrue(client.IsConnected);
        }
    }
}
