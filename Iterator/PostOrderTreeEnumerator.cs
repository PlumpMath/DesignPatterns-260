using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class PostOrderTreeEnumerator : IEnumerable<INode>
    {
        private INode Root;

        public PostOrderTreeEnumerator(INode root)
        {
            this.Root = root;
        }


        public IEnumerator<INode> GetEnumerator()
        {
            return PostOrder(Root);
        }

        private IEnumerator<INode> PostOrder(INode node)
        {
            var n = node as Node;
            if (n != null)
            {
                foreach (var a in new PostOrderTreeEnumerator(n.Right))
                    yield return a;

                yield return n;

                foreach (var a in new PostOrderTreeEnumerator(n.Left))
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
