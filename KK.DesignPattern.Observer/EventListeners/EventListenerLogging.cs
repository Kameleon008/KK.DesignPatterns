namespace KK.DesignPattern.Observer.EventListeners
{
    internal class EventListenerLogging : IEventListener
    {
        public void Update(string eventContent)
        {
            Console.WriteLine($"LOGGING: {eventContent}");
        }
    }
}
