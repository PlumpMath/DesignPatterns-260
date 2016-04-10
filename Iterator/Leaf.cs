namespace Iterator
{
    public class Leaf : INode
    {
        private int value;

        public Leaf(int value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}