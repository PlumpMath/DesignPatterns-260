using System.Collections.Generic;

namespace ChaonOfResponsibility
{
    public class Request
    {
        public Request()
        {
            HandledBy = new List<Handler>();
        }

        public List<Handler> HandledBy { get; set; }
    }
}