namespace KK.DesignPattern.Decorator
{
    internal class Notifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("Send Notification: {0}", message);
        }
    }
}
