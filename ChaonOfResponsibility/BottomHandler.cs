namespace ChaonOfResponsibility
{
    public class BottomHandler : Handler
    {
        public BottomHandler() : base(null)
        {
        }

        protected override void Process(Request request)
        {
            request.HandledBy.Add(this);
        }
    }
}