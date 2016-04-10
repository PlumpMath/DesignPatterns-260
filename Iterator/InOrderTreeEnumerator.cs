using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class InOrderTreeEnumerator : IEnumerable<INode>
    {
        public INode Root { get; private set; }

        public InOrderTreeEnumerator(INode root)
        {
            Root = root;
        }


        public IEnumerator<INode> GetEnumerator()
        {
            return InOrderEnumerate(Root);
        }

        private IEnumerator<INode> InOrderEnumerate(INode node)
        {
            var n = node as Node;
            if (n != null)
            {
                foreach (var a in new InOrderTreeEnumerator(n.Left))
                    yield return a;

                yield return n;

                foreach (var a in new InOrderTreeEnumerator(n.Right))
                    yield return a;
            }
            else
            {
                yield return node;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
