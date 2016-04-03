namespace ChaonOfResponsibility
{
    /// <summary>
    /// Abstract handler will process request and move request to next handler.
    /// </summary>
    public abstract class Handler
    {
        private readonly Handler subHandler;

        public Handler(Handler subHandler)
        {
            this.subHandler = subHandler;
        }

        public void Handle(Request request)
        {
            Process(request);
            if (subHandler != null)
                subHandler.Handle(request);
        }

        protected abstract void Process(Request request);
    }
}