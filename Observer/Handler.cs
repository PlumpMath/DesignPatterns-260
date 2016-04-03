using System;

namespace Observer
{
    public class Handler : IListener
    {
        private readonly string name;
        public string LastEvent { get; set; }

        public Handler(string name)
        {
            this.name = name;
        }

        public void Update(string @event)
        {
            Console.WriteLine(name + "is handling " + @event);
            LastEvent = @event;
        }
    }
}
