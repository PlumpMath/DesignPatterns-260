using System.Collections.Generic;

namespace Observer
{
    public class Generator
    {
        private List<IListener> observers;
        public Generator()
        {
            observers = new List<IListener>();
        }
        public void Generate(string @event)
        {
            observers.ForEach(o => o.Update(@event));
        }

        public void Subscribe(IListener listener)
        {
            observers.Add(listener);
        }
        public void Unsubscribe(IListener listener)
        {
            observers.Remove(listener);
        }
    }
}
