namespace ChaonOfResponsibility
{
    public class TopHandler : Handler
    {
        public TopHandler(BottomHandler handler) : base(handler)
        {
        }

        protected override void Process(Request request)
        {
            request.HandledBy.Add(this);
        }
    }
}