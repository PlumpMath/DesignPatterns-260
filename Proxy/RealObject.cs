namespace Proxy
{
    public class RealObject : IResourceHungryObject
    {
        public State ObjState { get; set; }
        public RealObject()
        {
            ObjState = State.Untouched;
        }
        public void DoIt()
        {
            ObjState = State.Touched;
        }

        public void SetParameter(int v)
        {
            ObjState = State.Touched;
        }
    }
}
