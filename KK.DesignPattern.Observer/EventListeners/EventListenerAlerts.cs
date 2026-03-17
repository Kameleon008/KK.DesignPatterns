namespace KK.DesignPattern.Observer.EventListeners
{
    internal class EventListenerAlerts : IEventListener
    {
        public void Update(string eventContent)
        {
            Console.WriteLine($"ALERT: {eventContent}");
        }
    }
}
