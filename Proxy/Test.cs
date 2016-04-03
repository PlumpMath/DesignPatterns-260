using NUnit.Framework;

namespace Proxy
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ProxyTest()
        {
            IResourceHungryObject proxy = new Proxy();
            proxy.SetParameter(10);
            Assert.AreEqual(((Proxy)proxy).RealObject.ObjState, State.Untouched);
            proxy.DoIt();
            Assert.AreEqual(((Proxy)proxy).RealObject.ObjState, State.Touched);
        }
    }
}
