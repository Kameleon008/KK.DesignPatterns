namespace KK.DesignPattern.Decorator.Decorators
{
    internal class EmailNotifier(INotifier notifier) : BaseDecorator(notifier)
    {
        public override void Notify(string message)
        {
            base.Notify(message);
            Console.WriteLine("Send Notification Email: {0}", message);
        }
    }
}
