namespace Iterator
{
    public class Node : INode
    {
        public INode Right { get; private set; }
        public INode Left { get; private set; }
        public int Value { get; private set; }

        public Node(INode left, INode right, int value)
        {
            this.Left = left;
            this.Right = right;
            this.Value = value;
        }


        public override string ToString()
        {
            return Value.ToString();
        }
    }
}