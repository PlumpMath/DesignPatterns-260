using NUnit.Framework;
using System.Linq;

namespace Iterator
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void IteratorTest()
        {
            /*
             *       4
             *    3    5
             *   1 2
             */

            var tree = new Node(new Node(new Leaf(1), new Leaf(2), 3), new Leaf(5), 4);
            var inOrderIterator = new InOrderTreeEnumerator(tree);

            Assert.AreEqual("13245", string.Join("", inOrderIterator.Select(a => a.ToString())));

            var postOrderIterator = new PostOrderTreeEnumerator(tree);
            Assert.AreEqual("54231", string.Join("", postOrderIterator.Select(a => a.ToString()).ToArray()));
        }
    }
}
