using NUnit.Framework;

namespace Observer
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ObserverTest()
        {
            var generator = new Generator();
            var observerA = new Handler("Tomas");
            var observerB = new Handler("Peter");

            Assert.IsNull(observerA.LastEvent);
            Assert.IsNull(observerB.LastEvent);

            generator.Generate("Fire");

            // event not handled because observers were not subscribed
            Assert.IsNull(observerA.LastEvent);
            Assert.IsNull(observerB.LastEvent);

            generator.Subscribe(observerA);
            generator.Subscribe(observerB);

            generator.Generate("Fire");
            // event is handled correctly
            Assert.AreEqual("Fire", observerA.LastEvent);
            Assert.AreEqual("Fire", observerB.LastEvent);
        }
    }
}
