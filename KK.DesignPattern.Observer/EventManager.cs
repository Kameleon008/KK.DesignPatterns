using KK.DesignPattern.Observer.EventListeners;

namespace KK.DesignPattern.Observer
{
    internal class EventManager
    {
        private List<(EventType type, IEventListener listener)> listeners = [];

        public void Subscribe(EventType type, IEventListener listener)
        {
            this.listeners.Add(new(type, listener));
        }

        public void Unsubscribe(EventType type, IEventListener listener)
        {
            listeners.Remove((type, listener));
        }

        public void Notify(EventType eventType, string data)
        {
            foreach (var listener in listeners.Where(listener => listener.type == eventType))
            {
                listener.listener.Update(data);
            }
        }
    }
}
